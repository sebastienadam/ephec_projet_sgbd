USE [master];
GO

-- ========================================================================== --
--   On casse tout avant de commencer                                         --
-- ========================================================================== --
IF EXISTS(SELECT * FROM sys.databases WHERE name='ProjetSGBD') BEGIN
  DROP DATABASE ProjetSGBD;
END
GO
CREATE DATABASE ProjetSGBD;
GO
USE ProjetSGBD;
GO

-- ========================================================================== --
--   Administrateur principal (on ne sait jamais, ça peut servir)             --
-- ========================================================================== --
IF EXISTS(SELECT name FROM sys.server_principals WHERE name = 'ProjetSGBD_RootAdmin') BEGIN
  DROP LOGIN ProjetSGBD_RootAdmin;
END
CREATE LOGIN ProjetSGBD_RootAdmin WITH PASSWORD = 'RootAdmin', CHECK_POLICY = OFF;
GO
CREATE USER RootAdmn FOR LOGIN ProjetSGBD_RootAdmin;
GO

ALTER ROLE db_accessadmin ADD MEMBER RootAdmn;
ALTER ROLE db_backupoperator ADD MEMBER RootAdmn;
ALTER ROLE db_datareader ADD MEMBER RootAdmn;
ALTER ROLE db_datawriter ADD MEMBER RootAdmn;
ALTER ROLE db_ddladmin ADD MEMBER RootAdmn;
ALTER ROLE db_owner ADD MEMBER RootAdmn;
ALTER ROLE db_securityadmin ADD MEMBER RootAdmn;
GO

-- ========================================================================== --
--   Schémas                                                                  --
-- ========================================================================== --
CREATE SCHEMA BACKOFFICE;
GO
CREATE SCHEMA MANAGERAREA;
GO
CREATE SCHEMA CLIENTAREA;
GO

-- ========================================================================== --
--   Rôles                                                                    --
-- ========================================================================== --
CREATE ROLE managers;
CREATE ROLE clients;
GO
DENY CONTROL ON SCHEMA :: BACKOFFICE TO managers, clients;
DENY CONTROL ON SCHEMA :: MANAGERAREA TO clients;
GRANT EXECUTE, SELECT ON SCHEMA :: MANAGERAREA TO managers;
GRANT EXECUTE, SELECT ON SCHEMA :: CLIENTAREA TO managers, clients;
GO

-- ========================================================================== --
--   Manager                                                                  --
-- ========================================================================== --
IF EXISTS(SELECT name FROM sys.server_principals WHERE name = 'ProjetSGBD_Manager') BEGIN
  DROP LOGIN ProjetSGBD_Manager;
END
CREATE LOGIN ProjetSGBD_Manager WITH PASSWORD = 'Manager', CHECK_POLICY = OFF;
GO
CREATE USER uManager FOR LOGIN ProjetSGBD_Manager;
GO
ALTER ROLE managers ADD MEMBER uManager;
GO

-- ========================================================================== --
--   Client                                                                   --
-- ========================================================================== --
IF EXISTS(SELECT name FROM sys.server_principals WHERE name = 'ProjetSGBD_Client') BEGIN
  DROP LOGIN ProjetSGBD_Client;
END
CREATE LOGIN ProjetSGBD_Client WITH PASSWORD = 'Client', CHECK_POLICY = OFF;
GO
CREATE USER usClient FOR LOGIN ProjetSGBD_Client;
GO
ALTER ROLE clients ADD MEMBER usClient;
GO

-- ========================================================================== --
--   Tables                                                                   --
-- ========================================================================== --
CREATE TABLE BACKOFFICE._BOOK (
  BOO_REC_ID int NOT NULL,
  BOO_CLI_ID int NOT NULL,
  BOO_VALID bit NOT NULL DEFAULT(0), -- BR004 (partial)
  BOO_UPDATE_AT datetime2,
  BOO_UPDATE_BY char(8),
  CONSTRAINT PK_BOOK PRIMARY KEY (BOO_REC_ID,BOO_CLI_ID) -- BR009
);
CREATE TABLE BACKOFFICE._CHOOSE (
  CCD_CLI_ID int NOT NULL,
  CCD_DIS_ID int NOT NULL,
  CCD_REC_ID int NOT NULL,
  CCD_UPDATE_AT datetime2,
  CCD_UPDATE_BY char(8),
  CONSTRAINT PK_CHOOSE PRIMARY KEY (CCD_CLI_ID,CCD_DIS_ID, CCD_REC_ID) -- BR017
);
CREATE TABLE BACKOFFICE._CLIENT(
  CLI_ID int IDENTITY(1,1) NOT NULL,
  CLI_ACRONYM char(8) NOT NULL,
  CLI_FNAME varchar(64) NOT NULL,
  CLI_LNAME varchar(64) NOT NULL,
  CLI_SEX char(1) NOT NULL,
  CLI_BDAY date NOT NULL,
  CLI_JOB varchar(64) NOT NULL,
  CLI_UPDATE_AT datetime2,
  CLI_UPDATE_BY char(8),
  CONSTRAINT PK_CLIENT PRIMARY KEY (CLI_ID),
  CONSTRAINT UK_CLIENT_ACRONYM UNIQUE (CLI_ACRONYM),
  CONSTRAINT UK_CLIENT_FIRST_LAST_NAME UNIQUE (CLI_FNAME, CLI_LNAME) -- BR0012
);
CREATE TABLE BACKOFFICE._DISH (
  DIS_ID int IDENTITY(1,1) NOT NULL,
  DIS_NAME varchar(64) NOT NULL,
  DIS_TYPE int NOT NULL,
  DIS_UPDATE_AT datetime2,
  DIS_UPDATE_BY char(8),
  CONSTRAINT PK_DISH PRIMARY KEY (DIS_ID),
  CONSTRAINT UK_DISH_NAME_TYPE UNIQUE (DIS_NAME, DIS_TYPE)
);
CREATE TABLE BACKOFFICE._DISHTYPE (
  DTY_ID int IDENTITY(1,1) NOT NULL,
  DTY_NAME varchar(64) NOT NULL,
  CONSTRAINT PK_DISHTYPE PRIMARY KEY (DTY_ID)
);
CREATE TABLE BACKOFFICE._FEELINGTYPE (
  FTY_ID int IDENTITY(1,1) NOT NULL,
  FTY_NAME varchar(64) NOT NULL,
  CONSTRAINT PK_FEELINGTYPE PRIMARY KEY (FTY_ID)
);
CREATE TABLE BACKOFFICE._FEEL_CLI_CLI (
  CFC_CLI_ID int NOT NULL,
  CFC_CLI_CLI_ID int NOT NULL,
  CFC_FTY_ID int NOT NULL,
  CFC_UPDATE_AT datetime2,
  CFC_UPDATE_BY char(8),
  CONSTRAINT PK_FEEL_CLI_CLI PRIMARY KEY (CFC_CLI_ID,CFC_CLI_CLI_ID) -- BR002
);
CREATE TABLE BACKOFFICE._FEEL_CLI_DIS (
  CFD_CLI_ID int NOT NULL,
  CFD_DIS_ID int NOT NULL,
  CFD_FTY_ID int NOT NULL,
  CFD_UPDATE_AT datetime2,
  CFD_UPDATE_BY char(8),
  CONSTRAINT PK_FEEL_CLI_DIS PRIMARY KEY (CFD_CLI_ID,CFD_DIS_ID) -- BR001
);
CREATE TABLE BACKOFFICE._OFFER (
  OFF_REC_ID int NOT NULL,
  OFF_DIS_ID int NOT NULL,
  OFF_UPDATE_AT datetime2,
  OFF_UPDATE_BY char(8),
  CONSTRAINT PK_OFFER PRIMARY KEY (OFF_REC_ID,OFF_DIS_ID) -- BR016
);
CREATE TABLE BACKOFFICE._RECEPTION (
  REC_ID int IDENTITY(1,1) NOT NULL,
  REC_NAME varchar(64) NOT NULL,
  REC_DATE datetime2 NOT NULL,
  REC_DATE_CLOSING_REG datetime2 NOT NULL,
  REC_CAPACITY int NOT NULL,
  REC_SEAT_TABLE int NOT NULL,
  REC_VALID bit NOT NULL DEFAULT(0), -- BR003 (partial)
  REC_UPDATE_AT datetime2,
  REC_UPDATE_BY char(8),
  CONSTRAINT PK_RECEPTION PRIMARY KEY (REC_ID),
  CONSTRAINT UK_RECEPTION_NAME_DATE UNIQUE (REC_NAME, REC_DATE)
);
CREATE TABLE BACKOFFICE._SIT (
  SIT_TAB_ID int NOT NULL,
  SIT_CLI_ID int NOT NULL,
  SIT_UPDATE_AT datetime2,
  SIT_UPDATE_BY char(8),
  CONSTRAINT PK_SIT PRIMARY KEY (SIT_TAB_ID,SIT_CLI_ID) -- BR010
);
CREATE TABLE BACKOFFICE._TABLE (
  TAB_ID int IDENTITY(1,1) NOT NULL,
  TAB_SEATING int NOT NULL,
  TAB_REC_ID int NOT NULL,
  TAB_UPDATE_AT datetime2,
  TAB_UPDATE_BY char(8),
  CONSTRAINT PK_TABLE PRIMARY KEY (TAB_ID)
);
ALTER TABLE BACKOFFICE._BOOK ADD CONSTRAINT FK_BOOK_CLI FOREIGN KEY (BOO_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._BOOK ADD CONSTRAINT FK_BOOK_REC FOREIGN KEY (BOO_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_CLI FOREIGN KEY (CCD_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_DIS FOREIGN KEY (CCD_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_REC FOREIGN KEY (CCD_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._DISH ADD CONSTRAINT FK_DISH_TYPE FOREIGN KEY (DIS_TYPE) REFERENCES BACKOFFICE._DISHTYPE (DTY_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_CLI1 FOREIGN KEY (CFC_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_CLI2 FOREIGN KEY (CFC_CLI_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_FEELINGTYPE FOREIGN KEY (CFC_FTY_ID) REFERENCES BACKOFFICE._FEELINGTYPE (FTY_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_CLI FOREIGN KEY (CFD_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_DISH FOREIGN KEY (CFD_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_FEELINGTYPE FOREIGN KEY (CFD_FTY_ID) REFERENCES BACKOFFICE._FEELINGTYPE (FTY_ID);
ALTER TABLE BACKOFFICE._OFFER ADD CONSTRAINT FK_OFFER_DIS FOREIGN KEY (OFF_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._OFFER ADD CONSTRAINT FK_OFFER_REC FOREIGN KEY (OFF_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._SIT ADD CONSTRAINT FK_SIT_CLI FOREIGN KEY (SIT_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._SIT ADD CONSTRAINT FK_SIT_TAB FOREIGN KEY (SIT_TAB_ID) REFERENCES BACKOFFICE._TABLE (TAB_ID);
ALTER TABLE BACKOFFICE._TABLE ADD CONSTRAINT FK_TABLE_RECEPTION FOREIGN KEY (TAB_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);

-- ========================================================================== --
--   Données statiques                                                        --
-- ========================================================================== --
INSERT INTO BACKOFFICE._FEELINGTYPE (FTY_NAME)
VALUES ('aimer'),
       ('déplaire');
INSERT INTO BACKOFFICE._DISHTYPE (DTY_NAME)
VALUES ('entrée'),
       ('plat principal'),
       ('dessert');
GO

-- ========================================================================== --
--   Vues                                                                     --
-- ========================================================================== --


-- ========================================================================== --
--   Fonctions                                                                --
-- ========================================================================== --
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Tests whether a reception is valid. To be valid, a reception
--              must offer at least one dish of each type. If the reception is
--              valid, returns 1. Otherwise return 0. (BR003)
-- =============================================================================
CREATE FUNCTION BACKOFFICE.IS_RECEPTION_VALID
(
  @REC_ID int
)
RETURNS BIT
AS
BEGIN
  DECLARE @Result bit;
  IF @REC_ID IS NULL BEGIN
    SET @Result = 0;
  END ELSE IF EXISTS(SELECT *
                     FROM BACKOFFICE._DISHTYPE
                     WHERE DTY_ID NOT IN (SELECT DISTINCT DIS_TYPE
                                          FROM BACKOFFICE._OFFER, BACKOFFICE._DISH
                                          WHERE OFF_DIS_ID = DIS_ID
                                            AND OFF_REC_ID = @REC_ID)) BEGIN
    SET @Result = 0;
  END ELSE BEGIN
    SET @Result = 1;
  END
  RETURN @Result;
END
GO

-- ========================================================================== --
--   Triggers                                                                 --
-- ========================================================================== --
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_CLIENT_INSERTUPDATE
   ON  BACKOFFICE._CLIENT
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  UPDATE BACKOFFICE._CLIENT SET
  CLI_UPDATE_AT = GETDATE(),
  CLI_UPDATE_BY = CURRENT_USER,
  CLI_SEX = UPPER(CLI_SEX)
  WHERE CLI_ID IN (SELECT CLI_ID FROM inserted);
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_DISH_INSERTUPDATE
   ON  BACKOFFICE._DISH
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  UPDATE BACKOFFICE._DISH SET
  DIS_UPDATE_AT = GETDATE(),
  DIS_UPDATE_BY = CURRENT_USER
  WHERE DIS_ID IN (SELECT DIS_ID FROM inserted);
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_FEEL_CLI_CLI_INSERTUPDATE
   ON  BACKOFFICE._FEEL_CLI_CLI
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @CliId int,
          @CliCliId int,
          @Error int;
  SET @Error = 0;
  DECLARE InsertCursorFeelCC CURSOR
  FOR SELECT CFC_CLI_ID, CFC_CLI_CLI_ID
      FROM inserted;
  OPEN InsertCursorFeelCC;
  FETCH InsertCursorFeelCC INTO @CliId, @CliCliId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    IF @CliId = @CliCliId BEGIN
      SET @Error = 50000;
      BREAK
    END
    UPDATE BACKOFFICE._FEEL_CLI_CLI
    SET CFC_UPDATE_AT = GETDATE(),
        CFC_UPDATE_BY = CURRENT_USER
    WHERE CFC_CLI_ID = @CliId AND CFC_CLI_CLI_ID = @CliCliId;
    FETCH InsertCursorFeelCC INTO @CliId, @CliCliId;
  END;
  CLOSE InsertCursorFeelCC;
  DEALLOCATE InsertCursorFeelCC;
  IF @Error <> 0 BEGIN
    ROLLBACK;
    THROW @Error, 'Fail to add client feeling for a client.', 1;
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_FEEL_CLI_DIS_INSERTUPDATE
   ON  BACKOFFICE._FEEL_CLI_DIS
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @CliId int,
          @DisId int;
  DECLARE InsertCursorFeelCD CURSOR
  FOR SELECT CFD_CLI_ID, CFD_DIS_ID
      FROM inserted;
  OPEN InsertCursorFeelCD;
  FETCH InsertCursorFeelCD INTO @CliId, @DisId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    UPDATE BACKOFFICE._FEEL_CLI_DIS
    SET CFD_UPDATE_AT = GETDATE(),
        CFD_UPDATE_BY = CURRENT_USER
    WHERE CFD_CLI_ID = @CliId AND CFD_DIS_ID = @DisId;
    FETCH InsertCursorFeelCD INTO @CliId, @DisId;
  END;
  CLOSE InsertCursorFeelCD;
  DEALLOCATE InsertCursorFeelCD;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it. Also validates the correspondig reception when a type
--              of each dish is offered. (BR003)
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_OFFER_INSERTUPDATE
   ON  BACKOFFICE._OFFER
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @RecId int,
          @DisId int,
          @Valid bit;
  DECLARE InsertCursorOffer CURSOR
  FOR SELECT OFF_REC_ID, OFF_DIS_ID
      FROM inserted;
  OPEN InsertCursorOffer;
  FETCH InsertCursorOffer INTO @RecId, @DisId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    UPDATE BACKOFFICE._OFFER
    SET OFF_UPDATE_AT = GETDATE(),
        OFF_UPDATE_BY = CURRENT_USER
    WHERE OFF_REC_ID = @RecId AND OFF_DIS_ID = @DisId;
    SELECT @Valid = REC_VALID
    FROM BACKOFFICE._RECEPTION
    WHERE REC_ID = @RecId;
    IF @Valid <> BACKOFFICE.IS_RECEPTION_VALID(@RecId) BEGIN
      UPDATE BACKOFFICE._RECEPTION
      SET REC_VALID = BACKOFFICE.IS_RECEPTION_VALID(@RecId)
      WHERE REC_ID = @RecId;
    END
    FETCH InsertCursorOffer INTO @RecId, @DisId;
  END;
  CLOSE InsertCursorOffer;
  DEALLOCATE InsertCursorOffer;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it. Also assigns the validation bit. (BR003)
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_RECEPTION_INSERTUPDATE
   ON  BACKOFFICE._RECEPTION
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @RecId int;
  DECLARE InsertCursorReception CURSOR
  FOR SELECT REC_ID
      FROM inserted;
  OPEN InsertCursorReception;
  FETCH InsertCursorReception INTO @RecId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    UPDATE BACKOFFICE._RECEPTION
    SET REC_UPDATE_AT = GETDATE(),
        REC_UPDATE_BY = CURRENT_USER,
        REC_VALID = BACKOFFICE.IS_RECEPTION_VALID(@RecId) -- BR003 (partial)
    WHERE REC_ID = @RecId;
    FETCH InsertCursorReception INTO @RecId;
  END;
  CLOSE InsertCursorReception;
  DEALLOCATE InsertCursorReception;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_SIT_INSERTUPDATE
   ON  BACKOFFICE._SIT
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @TabId int,
          @CliId int;
  DECLARE InsertCursorFeelCD CURSOR
  FOR SELECT SIT_TAB_ID, SIT_CLI_ID
      FROM inserted;
  OPEN InsertCursorFeelCD;
  FETCH InsertCursorFeelCD INTO @TabId, @CliId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    UPDATE BACKOFFICE._SIT
    SET SIT_UPDATE_AT = GETDATE(),
        SIT_UPDATE_BY = CURRENT_USER
    WHERE SIT_TAB_ID = @TabId AND SIT_CLI_ID = @CliId;
    FETCH InsertCursorFeelCD INTO @TabId, @CliId;
  END;
  CLOSE InsertCursorFeelCD;
  DEALLOCATE InsertCursorFeelCD;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_TABLE_INSERTUPDATE
   ON  BACKOFFICE._TABLE
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  UPDATE BACKOFFICE._TABLE SET
  TAB_UPDATE_AT = GETDATE(),
  TAB_UPDATE_BY = CURRENT_USER
  WHERE TAB_ID IN (SELECT TAB_ID FROM inserted);
END
GO

-- ========================================================================== --
--   Procédures stockées                                                      --
-- ========================================================================== --



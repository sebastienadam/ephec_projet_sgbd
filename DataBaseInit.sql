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
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._CHOOSE (
  CHO_CLI_ID int NOT NULL,
  CHO_DIS_ID int NOT NULL,
  CHO_REC_ID int NOT NULL,
  CHO_UPDATE_AT datetime2,
  CHO_UPDATE_BY char(8),
  CONSTRAINT PK_CHOOSE PRIMARY KEY (CHO_CLI_ID,CHO_DIS_ID, CHO_REC_ID) -- BR017
);
--------------------------------------------------------------------------------
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
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._DISH (
  DIS_ID int IDENTITY(1,1) NOT NULL,
  DIS_NAME varchar(64) NOT NULL,
  DIS_TYPE int NOT NULL,
  DIS_UPDATE_AT datetime2,
  DIS_UPDATE_BY char(8),
  CONSTRAINT PK_DISH PRIMARY KEY (DIS_ID),
  CONSTRAINT UK_DISH_NAME_TYPE UNIQUE (DIS_NAME, DIS_TYPE)
);
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._DISHTYPE (
  DTY_ID int IDENTITY(1,1) NOT NULL,
  DTY_NAME varchar(64) NOT NULL,
  CONSTRAINT PK_DISHTYPE PRIMARY KEY (DTY_ID)
);
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._FEELINGTYPE (
  FTY_ID int IDENTITY(1,1) NOT NULL,
  FTY_NAME varchar(64) NOT NULL,
  CONSTRAINT PK_FEELINGTYPE PRIMARY KEY (FTY_ID)
);
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._FEEL_CLI_CLI (
  FCC_CLI_ID int NOT NULL,
  FCC_CLI_CLI_ID int NOT NULL,
  FCC_FTY_ID int NOT NULL,
  FCC_UPDATE_AT datetime2,
  FCC_UPDATE_BY char(8),
  CONSTRAINT PK_FEEL_CLI_CLI PRIMARY KEY (FCC_CLI_ID,FCC_CLI_CLI_ID) -- BR002
);
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._FEEL_CLI_DIS (
  FCD_CLI_ID int NOT NULL,
  FCD_DIS_ID int NOT NULL,
  FCD_FTY_ID int NOT NULL,
  FCD_UPDATE_AT datetime2,
  FCD_UPDATE_BY char(8),
  CONSTRAINT PK_FEEL_CLI_DIS PRIMARY KEY (FCD_CLI_ID,FCD_DIS_ID) -- BR001
);
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._OFFER (
  OFF_REC_ID int NOT NULL,
  OFF_DIS_ID int NOT NULL,
  OFF_UPDATE_AT datetime2,
  OFF_UPDATE_BY char(8),
  CONSTRAINT PK_OFFER PRIMARY KEY (OFF_REC_ID,OFF_DIS_ID) -- BR016
);
--------------------------------------------------------------------------------
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
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._SIT (
  SIT_TAB_ID int NOT NULL,
  SIT_CLI_ID int NOT NULL,
  SIT_UPDATE_AT datetime2,
  SIT_UPDATE_BY char(8),
  CONSTRAINT PK_SIT PRIMARY KEY (SIT_TAB_ID,SIT_CLI_ID) -- BR010
);
--------------------------------------------------------------------------------
CREATE TABLE BACKOFFICE._TABLE (
  TAB_ID int IDENTITY(1,1) NOT NULL,
  TAB_SEATING int NOT NULL,
  TAB_REC_ID int NOT NULL,
  TAB_VALID  bit NOT NULL DEFAULT(0), -- BR008
  TAB_UPDATE_AT datetime2,
  TAB_UPDATE_BY char(8),
  CONSTRAINT PK_TABLE PRIMARY KEY (TAB_ID)
);
--------------------------------------------------------------------------------
ALTER TABLE BACKOFFICE._BOOK ADD CONSTRAINT FK_BOOK_CLI FOREIGN KEY (BOO_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._BOOK ADD CONSTRAINT FK_BOOK_REC FOREIGN KEY (BOO_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_CLI FOREIGN KEY (CHO_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_DIS FOREIGN KEY (CHO_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_REC FOREIGN KEY (CHO_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._DISH ADD CONSTRAINT FK_DISH_TYPE FOREIGN KEY (DIS_TYPE) REFERENCES BACKOFFICE._DISHTYPE (DTY_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_CLI1 FOREIGN KEY (FCC_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_CLI2 FOREIGN KEY (FCC_CLI_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_FEELINGTYPE FOREIGN KEY (FCC_FTY_ID) REFERENCES BACKOFFICE._FEELINGTYPE (FTY_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_CLI FOREIGN KEY (FCD_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_DISH FOREIGN KEY (FCD_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_FEELINGTYPE FOREIGN KEY (FCD_FTY_ID) REFERENCES BACKOFFICE._FEELINGTYPE (FTY_ID);
ALTER TABLE BACKOFFICE._OFFER ADD CONSTRAINT FK_OFFER_DIS FOREIGN KEY (OFF_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._OFFER ADD CONSTRAINT FK_OFFER_REC FOREIGN KEY (OFF_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._SIT ADD CONSTRAINT FK_SIT_CLI FOREIGN KEY (SIT_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._SIT ADD CONSTRAINT FK_SIT_TAB FOREIGN KEY (SIT_TAB_ID) REFERENCES BACKOFFICE._TABLE (TAB_ID);
ALTER TABLE BACKOFFICE._TABLE ADD CONSTRAINT FK_TABLE_RECEPTION FOREIGN KEY (TAB_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);

-- ========================================================================== --
--   Données statiques                                                        --
-- ========================================================================== --
INSERT INTO BACKOFFICE._FEELINGTYPE (FTY_NAME)
VALUES ('aime'),
       ('n''aime pas');
INSERT INTO BACKOFFICE._DISHTYPE (DTY_NAME)
VALUES ('entrée'),
       ('plat principal'),
       ('dessert');
GO

-- ========================================================================== --
--   Vues                                                                     --
-- ========================================================================== --
CREATE VIEW CLIENTAREA.Client AS
SELECT CLI_ACRONYM AS Acronym,
       CLI_FNAME AS FirstName,
       CLI_LNAME AS LastName,
       CLI_SEX AS Sex,
       CLI_BDAY AS BirthDay,
       CLI_JOB AS Job,
       CLI_ID AS ClientId,
       CLI_UPDATE_AT AS ModifiedAt,
       CLI_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._CLIENT;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.Dish AS
SELECT DTY_NAME AS [Type],
       DIS_NAME AS Name,
       DIS_ID AS DishId,
       DTY_ID AS DishTypeId,
       DIS_UPDATE_AT AS ModifiedAt,
       DIS_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._DISH, BACKOFFICE._DISHTYPE
WHERE DIS_TYPE = DTY_ID;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.DishType AS
SELECT DTY_NAME AS Label,
       DTY_ID AS Id
FROM BACKOFFICE._DISHTYPE;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.DishWish AS
SELECT CLI_FNAME AS ClientFirstName,
       CLI_LNAME AS ClientLastName,
       FTY_NAME AS Feeling,
       DTY_NAME AS DishType,
       DIS_NAME AS DishName,
       CLI_ID AS ClientId,
       DIS_ID AS DishId,
       DTY_ID AS DishTypeId,
       FTY_ID AS FeelingTypeId,
       FCD_UPDATE_AT AS ModifiedAt,
       FCD_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._FEEL_CLI_DIS,
     BACKOFFICE._CLIENT,
     BACKOFFICE._DISH,
     BACKOFFICE._DISHTYPE,
     BACKOFFICE._FEELINGTYPE
WHERE FCD_CLI_ID = CLI_ID
  AND FCD_DIS_ID = DIS_ID
  AND DIS_TYPE = DTY_ID
  AND FCD_FTY_ID = FTY_ID;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.Feeling AS
SELECT _CLIENT_FROM.CLI_FNAME AS ClientFromFirstName,
       _CLIENT_FROM.CLI_LNAME AS ClientFromLastName,
       FTY_NAME AS Feeling,
       _CLIENT_TO.CLI_FNAME AS ClientToFirstName,
       _CLIENT_TO.CLI_LNAME AS ClientToLastName,
       _CLIENT_FROM.CLI_ID AS ClientFromId,
       _CLIENT_TO.CLI_ID AS ClientToId,
       FTY_ID AS FeelingTypeId,
       FCC_UPDATE_AT AS ModifiedAt,
       FCC_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._FEEL_CLI_CLI,
     BACKOFFICE._CLIENT AS _CLIENT_FROM,
     BACKOFFICE._CLIENT AS _CLIENT_TO,
     BACKOFFICE._FEELINGTYPE
WHERE FCC_CLI_ID = _CLIENT_FROM.CLI_ID
  AND FCC_CLI_CLI_ID = _CLIENT_TO.CLI_ID
  AND FCC_FTY_ID = FTY_ID;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.FeelingType AS
SELECT FTY_NAME AS Label,
       FTY_ID AS Id
FROM BACKOFFICE._FEELINGTYPE;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.Menu AS
SELECT REC_NAME AS ReceptionName,
       REC_DATE AS ReceptionDate,
       DTY_NAME AS DishType,
       DIS_NAME AS DishName,
       REC_ID AS ReceptionId,
       DIS_ID AS DishId,
       DTY_ID AS DishTypeId,
       OFF_UPDATE_AT AS ModifiedAt,
       OFF_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._RECEPTION,
     BACKOFFICE._OFFER,
     BACKOFFICE._DISH,
     BACKOFFICE._DISHTYPE
WHERE REC_ID = OFF_REC_ID
  AND OFF_DIS_ID = DIS_ID
  AND DIS_TYPE = DTY_ID;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.Reception AS
SELECT REC_NAME AS Name,
       REC_DATE AS [Date],
       REC_DATE_CLOSING_REG AS BookingClosingDate,
       REC_CAPACITY AS Capacity,
       REC_SEAT_TABLE AS SeatsPerTable,
       REC_VALID AS IsValid,
       REC_ID AS ReceptionId,
       REC_UPDATE_AT AS ModifiedAt,
       REC_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._RECEPTION;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.Reservation AS
SELECT REC_NAME AS ReceptionName,
       REC_DATE AS ReceptionDate,
       CLI_FNAME AS ClientFirstName,
       CLI_LNAME AS ClientLastName,
       BOO_VALID AS IsValid,
       REC_ID AS ReceptionId,
       CLI_ID AS ClientId,
       BOO_UPDATE_AT AS ModifiedAt,
       BOO_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._RECEPTION,
     BACKOFFICE._BOOK,
     BACKOFFICE._CLIENT
WHERE REC_ID = BOO_REC_ID
  AND BOO_CLI_ID = CLI_ID;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.ReservedDish AS
SELECT REC_NAME AS ReceptionName,
       REC_DATE AS ReceptionDate,
       CLI_FNAME AS ClientFirstName,
       CLI_LNAME AS ClientLastName,
       DTY_NAME AS DishType,
       DIS_ID AS DishName,
       REC_ID AS ReceptionId,
       CLI_ID AS ClientId,
       DIS_ID AS DishId,
       DTY_ID AS DishTypeId,
       CHO_UPDATE_AT AS ModifiedAt,
       CHO_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._RECEPTION,
     BACKOFFICE._CHOOSE,
     BACKOFFICE._DISH,
     BACKOFFICE._DISHTYPE,
     BACKOFFICE._CLIENT
WHERE REC_ID = CHO_REC_ID
  AND CHO_CLI_ID = CLI_ID
  AND CHO_DIS_ID = DIS_ID
  AND DIS_TYPE = DTY_ID;
GO
--------------------------------------------------------------------------------
CREATE VIEW CLIENTAREA.TablesMap AS
SELECT REC_NAME AS ReceptionName,
       REC_DATE AS ReceptionDate,
       TAB_ID AS TableId,
       CLI_FNAME AS ClientFirstName,
       CLI_LNAME AS ClientLastName,
       TAB_VALID AS IsValid,
       REC_ID AS ReceptionId,
       CLI_ID AS ClientId,
       SIT_UPDATE_AT AS ModifiedAt,
       SIT_UPDATE_BY AS ModifiedBy
FROM BACKOFFICE._RECEPTION,
     BACKOFFICE._TABLE,
     BACKOFFICE._SIT,
     BACKOFFICE._CLIENT
WHERE REC_ID = TAB_REC_ID
  AND TAB_ID = SIT_TAB_ID
  AND SIT_CLI_ID = CLI_ID;
GO

-- ========================================================================== --
--   Fonctions                                                                --
-- ========================================================================== --
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Tests if the reservation is valid for a reception. For a
--              reservation to be valid, it is necessary that the customer has
--              reserved its menu. If the reservation is valid, returns 1.
--              Otherwise return 0. (BR004)
-- =============================================================================
CREATE FUNCTION BACKOFFICE.IS_VALID_BOOK
(
  @RecId int,
  @CliId int
)
RETURNS bit
AS
BEGIN
  DECLARE @Result bit;
  IF (@RecId IS NULL) OR (@CliId IS NULL) BEGIN
    SET @Result = 0;
  END ELSE IF EXISTS(SELECT *
                     FROM BACKOFFICE._DISHTYPE
                     WHERE DTY_ID NOT IN (SELECT DISTINCT DIS_TYPE
                                          FROM BACKOFFICE._CHOOSE, BACKOFFICE._DISH
                                          WHERE CHO_DIS_ID = DIS_ID
                                            AND CHO_CLI_ID = @CliId
                                            AND CHO_REC_ID = @RecId)) BEGIN
    SET @Result = 0;
  END ELSE BEGIN
    SET @Result = 1;
  END
  RETURN @Result;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Tests whether a reception is valid. To be valid, a reception
--              must offer at least one dish of each type. If the reception is
--              valid, returns 1. Otherwise return 0. (BR003)
-- =============================================================================
CREATE FUNCTION BACKOFFICE.IS_VALID_RECEPTION
(
  @RecId int
)
RETURNS BIT
AS
BEGIN
  DECLARE @Result bit;
  IF @RecId IS NULL BEGIN
    SET @Result = 0;
  END ELSE IF EXISTS(SELECT *
                     FROM BACKOFFICE._DISHTYPE
                     WHERE DTY_ID NOT IN (SELECT DISTINCT DIS_TYPE
                                          FROM BACKOFFICE._OFFER, BACKOFFICE._DISH
                                          WHERE OFF_DIS_ID = DIS_ID
                                            AND OFF_REC_ID = @RecId)) BEGIN
    SET @Result = 0;
  END ELSE BEGIN
    SET @Result = 1;
  END
  RETURN @Result;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description:    Tests whether a table is valid. To be valid, a table must have
--              at least two customers who are seated. If the table is valid,
--              returns 1. Otherwise return 0. (BR008)
-- =============================================================================
CREATE FUNCTION BACKOFFICE.IS_VALID_TABLE
(
    @TabId int
)
RETURNS bit
AS
BEGIN
  DECLARE @Result bit;
  IF EXISTS(SELECT *
            FROM BACKOFFICE._SIT
            WHERE SIT_TAB_ID = @TabId
            HAVING COUNT(*) < 2) BEGIN
    SET @Result = 0;
  END ELSE BEGIN
    SET @Result = 1;
  END
  RETURN @Result;
END
GO

-- ========================================================================== --
--   Procédures stockées                                                      --
-- ========================================================================== --
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Assignes the validation bit of a reservation for a reception.
-- =============================================================================
CREATE PROCEDURE BACKOFFICE.SP_VALIDATE_BOOK
  @RecId int,
  @CliId int
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @ValidStatus bit,
          @IsValid bit;
  IF (@RecId IS NOT NULL) AND (@CliId IS NOT NULL) BEGIN
    SET @IsValid = BACKOFFICE.IS_VALID_BOOK(@RecId, @CliId);
    SELECT @ValidStatus = BOO_VALID
    FROM BACKOFFICE._BOOK
    WHERE BOO_REC_ID = @RecId AND BOO_CLI_ID = @CliId;
    IF @IsValid <> @ValidStatus BEGIN
      UPDATE BACKOFFICE._BOOK
      SET BOO_VALID = @IsValid
      WHERE BOO_CLI_ID = @CliId AND BOO_REC_ID = @RecId;
    END
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Assignes the validation bit of a reception.
-- =============================================================================
CREATE PROCEDURE BACKOFFICE.SP_VALIDATE_RECEPTION
  @RecId int
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @ValidStatus bit,
          @IsValid bit;
  IF @RecId IS NOT NULL BEGIN
    SET @IsValid = BACKOFFICE.IS_VALID_RECEPTION(@RecId);
    SELECT @ValidStatus = REC_VALID
    FROM BACKOFFICE._RECEPTION
    WHERE REC_ID = @RecId;
    IF @IsValid <> @ValidStatus BEGIN
      UPDATE BACKOFFICE._RECEPTION
      SET REC_VALID = @IsValid
      WHERE REC_ID = @RecId;
    END
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Assignes the validation bit of a table for a reception.
-- =============================================================================
CREATE PROCEDURE BACKOFFICE.SP_VALIDATE_TABLE
  @TabId int
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @ValidStatus bit,
          @IsValid bit;
  IF @TabId IS NOT NULL BEGIN
    SET @IsValid = BACKOFFICE.IS_VALID_TABLE(@TabId);
    SELECT @ValidStatus = TAB_VALID
    FROM BACKOFFICE._TABLE
    WHERE TAB_ID = @TabId;
    IF @IsValid <> @ValidStatus BEGIN
      UPDATE BACKOFFICE._TABLE
      SET TAB_VALID = @IsValid
      WHERE TAB_ID = @TabId;
    END
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the list of the dishes that are NOT (un)liked by a
--              client.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_DISH_UNWISH
  @CliId int
AS
BEGIN
  SET NOCOUNT ON;
  SELECT [Type], Name, DishId, DishTypeId
  FROM CLIENTAREA.Dish
  WHERE DishId NOT IN (SELECT DishId
                       FROM CLIENTAREA.DishWish
                       WHERE ClientId = @CliId)
  ORDER BY DishTypeId, Name;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the list of the dishes that are (un)liked by a client.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_DISH_WISH
  @CliId int,
  @FtyId int = NULL
AS
BEGIN
  SET NOCOUNT ON;
  IF @FtyId IS NULL BEGIN
    SELECT Feeling,
           DishType,
           DishName,
           DishId,
           DishTypeId,
           FeelingTypeId,
           ModifiedAt,
           ModifiedBy
    FROM CLIENTAREA.DishWish
    WHERE ClientId = @CliId
    ORDER BY DishTypeId, DishName;
  END ELSE BEGIN
    SELECT DishType,
           DishName,
           DishId,
           DishTypeId,
           ModifiedAt,
           ModifiedBy
    FROM CLIENTAREA.DishWish
    WHERE ClientId = @CliId
      AND FeelingTypeId = @FtyId
    ORDER BY DishTypeId, DishName;
  END
END
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the list of the dishes to prepare for a reception.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_DISHES_TO_PREPARE
  @RecId int
AS
BEGIN
  SET NOCOUNT ON;
  SELECT DishType,
         DishName,
         DishId,
         DishTypeId,
         COUNT(*) AS Quantity
  FROM CLIENTAREA.ReservedDish
  WHERE ReceptionId = @RecId
  GROUP BY DishType, DishName
  ORDER BY DishTypeId, DishName;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the list of the clients that are (un)liked by a client.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_FEELING
  @CliId int,
  @FtyId int = NULL
AS
BEGIN
  SET NOCOUNT ON;
  IF @FtyId IS NULL BEGIN
    SELECT ClientToFirstName AS FirstName,
           ClientToLastName AS LastName,
           Feeling,
           ClientToId AS ClientId,
           FeelingTypeId,
           ModifiedAt,
           ModifiedBy
    FROM CLIENTAREA.Feeling
    WHERE ClientFromId = @CliId
    ORDER BY ClientToLastName, ClientToFirstName;
  END ELSE BEGIN
    SELECT ClientToFirstName AS FirstName,
           ClientToLastName AS LastName,
           ClientToId AS ClientId,
           ModifiedAt,
           ModifiedBy
    FROM CLIENTAREA.Feeling
    WHERE ClientFromId = @CliId
      AND FeelingTypeId = @FtyId
    ORDER BY ClientToLastName, ClientToFirstName;
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the menu for a given reception.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_MENU
  @RecId int,
  @DtyId int = NULL
AS
BEGIN
  IF @DtyId IS NULL BEGIN
    SELECT DishType,
           DishName,
           DishId,
           DishTypeId,
           ModifiedAt,
           ModifiedBy
    FROM CLIENTAREA.Menu
    WHERE ReceptionID = @RecId
    ORDER BY DishTypeId, DishName;
  END ELSE BEGIN
    SELECT DishName,
           DishId,
           ModifiedAt,
           ModifiedBy
    FROM CLIENTAREA.Menu
    WHERE ReceptionID = @RecId
      AND DishTypeId = @DtyId
    ORDER BY DishName;
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the list of the clients who have booked for a reception.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_RESERVATION
  @RecId int
AS
BEGIN
  SET NOCOUNT ON;
  SELECT ClientFirstName,
         ClientLastName,
         IsValid,
         ClientId,
         ModifiedAt,
         ModifiedBy
  FROM CLIENTAREA.Reservation
  WHERE ReceptionId = @RecId
  ORDER BY ClientLastName, ClientFirstName;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the list of the clients with the dishes they ordered for
--              a reception.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_RESERVED_DISH
  @RecId int
AS
BEGIN
  SET NOCOUNT ON;
  SELECT ClientFirstName,
         ClientLastName,
         DishType,
         DishName,
         ClientId,
         DishId,
         DishTypeId,
         ModifiedAt,
         ModifiedBy
  FROM CLIENTAREA.ReservedDish
  WHERE ReceptionId = @RecId
  ORDER BY ClientLastName, ClientFirstName;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the tables map for a reception.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_TABLE_MAP
  @RecId int,
  @TabId int = NULL
AS
BEGIN
  SET NOCOUNT ON;
  IF @TabId IS NULL BEGIN
    SELECT TableId,
           ClientFirstName,
           ClientLastName,
           IsValid, ReceptionId,
           ClientId,
           ModifiedAt,
           ModifiedBy
    FROM CLIENTAREA.TablesMap
    WHERE ReceptionId = @RecId;
  END ELSE BEGIN
    SELECT ClientFirstName,
           ClientLastName,
           IsValid,
           ReceptionId,
           ClientId,
           ModifiedAt,
           ModifiedBy
    FROM CLIENTAREA.TablesMap
    WHERE ReceptionId = @RecId
      AND TableId = @TabId;
  END
END
GO-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Returns the list of the clients that are NOT (un)liked by a
--              client.
-- =============================================================================
CREATE PROCEDURE CLIENTAREA.SP_UNFEELING
  @CliId int
AS
BEGIN
  SET NOCOUNT ON;
  SELECT FirstName, LastName, ClientId
  FROM CLIENTAREA.Client
  WHERE ClientId NOT IN (SELECT ClientToId
                         FROM CLIENTAREA.Feeling
                         WHERE ClientFromId = @CliId)
    AND ClientId <> @CliId
  ORDER BY LastName, FirstName;
END
GO

-- ========================================================================== --
--   Triggers                                                                 --
-- ========================================================================== --
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: When delete a reservation, delete all dependenties
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_BOOK_DELETE
   ON BACKOFFICE._BOOK
   AFTER DELETE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @CliId int,
          @RecId int;
  DECLARE DeleteCursorBook CURSOR
  FOR SELECT BOO_REC_ID, BOO_CLI_ID
      FROM deleted;
  OPEN DeleteCursorBook;
  FETCH DeleteCursorBook INTO @RecId, @CliId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    DELETE FROM BACKOFFICE._CHOOSE
    WHERE CHO_CLI_ID = @CliId AND CHO_REC_ID = @RecId;
    DELETE FROM BACKOFFICE._SIT
    WHERE SIT_CLI_ID = @CliId AND SIT_TAB_ID IN (SELECT TAB_ID
                                                 FROM BACKOFFICE._TABLE
                                                 WHERE TAB_REC_ID = @RecId);
    FETCH DeleteCursorBook INTO @RecId, @CliId;
  END;
  CLOSE DeleteCursorBook;
  DEALLOCATE DeleteCursorBook;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it. Verifies that:
--              - the reception is valid (BR004)
--              - the registration for the reception is not closed (BR014)
--              - the client does not register many receptions that go together
--                (BR020)
--              Also assigns the validation bit. (BR004)
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_BOOK_INSERTUPDATE
   ON BACKOFFICE._BOOK
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @RecId int,
          @CliId int,
          @Error int,
          @RecDate datetime2,
          @RecCloseDate datetime2,
          @Now datetime2;
  SET @Error = 0;
  DECLARE InsertCursorBook CURSOR
  FOR SELECT BOO_REC_ID, BOO_CLI_ID
      FROM inserted;
  OPEN InsertCursorBook;
  FETCH InsertCursorBook INTO @RecId, @CliId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    IF BACKOFFICE.IS_VALID_RECEPTION(@RecId) <> 1 BEGIN
      SET @Error = 50002;
      BREAK;
    END
    SELECT @RecDate = REC_DATE, @RecCloseDate = REC_DATE_CLOSING_REG
    FROM BACKOFFICE._RECEPTION
    WHERE REC_ID = @RecId;
    SET @Now = GETDATE();
    IF @RecCloseDate > @Now BEGIN
      SET @Error = 50008;
      BREAK;
    END
    IF EXISTS(SELECT *
              FROM BACKOFFICE._RECEPTION
              WHERE REC_ID IN (SELECT BOO_REC_ID
                               FROM BACKOFFICE._BOOK
                               WHERE BOO_CLI_ID = @CliId)
                AND REC_ID <> @RecId
                AND REC_DATE BETWEEN DATEADD(HOUR,-4,@RecDate) AND DATEADD(HOUR,4,@RecDate)) BEGIN
      SET @Error = 50009;
      BREAK;
    END
    UPDATE BACKOFFICE._BOOK
    SET BOO_UPDATE_AT = @Now,
        BOO_UPDATE_BY = CURRENT_USER,
        BOO_VALID = BACKOFFICE.IS_VALID_BOOK(@RecId, @CliId) -- BR004 (partial)
    WHERE BOO_REC_ID = @RecId AND BOO_CLI_ID = @CliId;
    FETCH InsertCursorBook INTO @RecId, @CliId;
  END;
  CLOSE InsertCursorBook;
  DEALLOCATE InsertCursorBook;
  IF @Error <> 0 BEGIN
    ROLLBACK;
    THROW @Error, 'Fail to book a reception.', 1;
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Update reservation validation tag.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_CHOOSE_DELETE
  ON BACKOFFICE._CHOOSE
  AFTER DELETE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @CliId int,
          @RecId int;
  DECLARE DeleteCursorChoose CURSOR
  FOR SELECT CHO_REC_ID, CHO_CLI_ID
      FROM deleted;
  OPEN DeleteCursorChoose;
  FETCH DeleteCursorChoose INTO @RecId, @CliId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    EXECUTE BACKOFFICE.SP_VALIDATE_BOOK @RecId, @CliId;
    FETCH DeleteCursorChoose INTO @RecId, @CliId;
  END;
  CLOSE DeleteCursorChoose;
  DEALLOCATE DeleteCursorChoose;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it. Also ensures that:
--              - the customer has booked for the reception for which he chooses
--                his dish (BR005)
--              - the chosen dish is proposed at the chosen reception (BR019)
--              - the customer provided only one dish of each type for a given
--                reception (BR004)
--              If the customer chose a dish of each type, validate booking.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_CHOOSE_INSERTUPDATE
  ON  BACKOFFICE._CHOOSE
  AFTER INSERT,UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @CliId int,
          @DisId int,
          @RecId int,
          @Error int;
  SET @Error = 0;
  DECLARE InsertCursorChoose CURSOR
  FOR SELECT CHO_CLI_ID, CHO_DIS_ID, CHO_REC_ID
      FROM inserted;
  OPEN InsertCursorChoose;
  FETCH InsertCursorChoose INTO @CliId, @DisId, @RecId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    IF NOT EXISTS(SELECT *
                  FROM BACKOFFICE._BOOK
                  WHERE BOO_CLI_ID = @CliId AND BOO_REC_ID = @RecId) BEGIN
      SET @Error = 50003;
      BREAK;
    END
    IF NOT EXISTS(SELECT *
                  FROM BACKOFFICE._OFFER
                  WHERE OFF_DIS_ID = @DisId AND OFF_REC_ID = @RecId) BEGIN
      SET @Error = 50004;
      BREAK;
    END
    IF EXISTS(SELECT *
              FROM BACKOFFICE._DISH
              WHERE DIS_ID = @DisId
                AND DIS_TYPE IN (SELECT DIS_TYPE
                                 FROM BACKOFFICE._CHOOSE, BACKOFFICE._DISH
                                 WHERE CHO_DIS_ID = DIS_ID
                                   AND CHO_CLI_ID = @CliId
                                   AND CHO_REC_ID = @RecId
                                   AND CHO_DIS_ID <> @DisId)) BEGIN
      SET @Error = 50001;
      BREAK;
    END
    UPDATE BACKOFFICE._CHOOSE
    SET CHO_UPDATE_AT = GETDATE(),
        CHO_UPDATE_BY = CURRENT_USER
    WHERE CHO_CLI_ID = @CliId AND CHO_DIS_ID = @DisId AND CHO_REC_ID = @RecId;
    EXECUTE BACKOFFICE.SP_VALIDATE_BOOK @RecId, @CliId;
    FETCH InsertCursorChoose INTO @CliId, @DisId, @RecId;
  END;
  CLOSE InsertCursorChoose;
  DEALLOCATE InsertCursorChoose;
  IF @Error <> 0 BEGIN
    ROLLBACK;
    THROW @Error, 'Fail to choose a dish for a reception.', 1;
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_CLIENT_INSERTUPDATE
   ON BACKOFFICE._CLIENT
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
   ON BACKOFFICE._DISH
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
--              made it. Also prohibit a client to feel something to himself
--              (BR018)
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_FEEL_CLI_CLI_INSERTUPDATE
   ON BACKOFFICE._FEEL_CLI_CLI
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @CliId int,
          @CliCliId int,
          @Error int;
  SET @Error = 0;
  DECLARE InsertCursorFeelCC CURSOR
  FOR SELECT FCC_CLI_ID, FCC_CLI_CLI_ID
      FROM inserted;
  OPEN InsertCursorFeelCC;
  FETCH InsertCursorFeelCC INTO @CliId, @CliCliId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    IF @CliId = @CliCliId BEGIN
      SET @Error = 50000;
      BREAK
    END
    UPDATE BACKOFFICE._FEEL_CLI_CLI
    SET FCC_UPDATE_AT = GETDATE(),
        FCC_UPDATE_BY = CURRENT_USER
    WHERE FCC_CLI_ID = @CliId AND FCC_CLI_CLI_ID = @CliCliId;
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
   ON BACKOFFICE._FEEL_CLI_DIS
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @CliId int,
          @DisId int;
  DECLARE InsertCursorFeelCD CURSOR
  FOR SELECT FCD_CLI_ID, FCD_DIS_ID
      FROM inserted;
  OPEN InsertCursorFeelCD;
  FETCH InsertCursorFeelCD INTO @CliId, @DisId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    UPDATE BACKOFFICE._FEEL_CLI_DIS
    SET FCD_UPDATE_AT = GETDATE(),
        FCD_UPDATE_BY = CURRENT_USER
    WHERE FCD_CLI_ID = @CliId AND FCD_DIS_ID = @DisId;
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
   ON BACKOFFICE._OFFER
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
    EXECUTE BACKOFFICE.SP_VALIDATE_RECEPTION @RecId;
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
   ON BACKOFFICE._RECEPTION
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
        REC_VALID = BACKOFFICE.IS_VALID_RECEPTION(@RecId) -- BR003 (partial)
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
-- Description: Update the validation bit of a table.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_SIT_DELETE
  ON BACKOFFICE._SIT
  AFTER DELETE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @TabId int;
  DECLARE DeleteCursorTable CURSOR
  FOR SELECT DISTINCT SIT_TAB_ID
      FROM deleted;
  OPEN DeleteCursorTable;
  FETCH DeleteCursorTable INTO @TabId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    EXECUTE BACKOFFICE.SP_VALIDATE_TABLE @TabId;
    FETCH DeleteCursorTable INTO @TabId;
  END;
  CLOSE DeleteCursorTable;
  DEALLOCATE DeleteCursorTable;
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it. Also ensure that:
--              - there are no more client sitting at a table that seats at the
--                table. (BR007)
--              - a client is registered at the reception to sit down. (BR011)
--              - a client does not sit at several tables in the same reception.
--                (BR010)
--              Also assign the validation bit of the table. (BR008)
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_SIT_INSERTUPDATE
   ON BACKOFFICE._SIT
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @TabId int,
          @CliId int,
          @RecId int,
          @Error int;
  SET @Error = 0;
  DECLARE InsertCursorSit CURSOR
  FOR SELECT DISTINCT SIT_TAB_ID
      FROM inserted;
  OPEN InsertCursorSit;
  FETCH InsertCursorSit INTO @TabId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    IF EXISTS(SELECT COUNT(*)
              FROM BACKOFFICE._SIT
              WHERE SIT_TAB_ID = @TabId
              GROUP BY SIT_TAB_ID
              HAVING COUNT(*) > (SELECT TAB_SEATING
                                 FROM BACKOFFICE._TABLE
                                 WHERE TAB_ID = @TabId)) BEGIN
      SET @Error = 50007;
      BREAK;
    END
    FETCH InsertCursorSit INTO @TabId;
  END
  CLOSE InsertCursorSit;
  DEALLOCATE InsertCursorSit;
  IF @Error = 0 BEGIN
    DECLARE InsertCursorSit CURSOR
    FOR SELECT SIT_TAB_ID, SIT_CLI_ID
        FROM inserted;
    OPEN InsertCursorSit;
    FETCH InsertCursorSit INTO @TabId, @CliId;
    WHILE @@FETCH_STATUS = 0 BEGIN
      SELECT @RecId = TAB_REC_ID
      FROM BACKOFFICE._TABLE
      WHERE TAB_ID = @TabId;
      IF NOT EXISTS(SELECT *
                    FROM BACKOFFICE._BOOK
                    WHERE BOO_CLI_ID = @CliId AND BOO_REC_ID = @RecId) BEGIN
        SET @Error = 50006;
        BREAK;
      END
      IF EXISTS(SELECT *
                FROM BACKOFFICE._SIT
                WHERE SIT_CLI_ID = @CliId
                  AND SIT_TAB_ID <> @TabId
                  AND SIT_TAB_ID IN (SELECT TAB_ID
                                     FROM BACKOFFICE._TABLE
                                     WHERE TAB_REC_ID = @RecId)) BEGIN
        SET @Error = 50005;
        BREAK;
      END
      UPDATE BACKOFFICE._SIT
      SET SIT_UPDATE_AT = GETDATE(),
          SIT_UPDATE_BY = CURRENT_USER
      WHERE SIT_TAB_ID = @TabId AND SIT_CLI_ID = @CliId;
      FETCH InsertCursorSit INTO @TabId, @CliId;
    END;
    CLOSE InsertCursorSit;
    DEALLOCATE InsertCursorSit;
  END
  IF @Error = 0 BEGIN
    DECLARE InsertCursorSit CURSOR
    FOR SELECT DISTINCT SIT_TAB_ID
        FROM inserted;
    OPEN InsertCursorSit;
    FETCH InsertCursorSit INTO @TabId;
    WHILE @@FETCH_STATUS = 0 BEGIN
      EXECUTE SP_VALIDATE_TABLE @TabId;
      FETCH InsertCursorSit INTO @TabId;
    END
    CLOSE InsertCursorSit;
  END
  DEALLOCATE InsertCursorSit;
  IF @Error <> 0 BEGIN
    ROLLBACK;
    THROW @Error, 'Fail to sit a client.', 1;
  END
END
GO
-- =============================================================================
-- Author:      Sébastien Adam
-- Create date: Dec2015
-- Description: Automatically assigns the modification date and the user who
--              made it.
-- =============================================================================
CREATE TRIGGER BACKOFFICE.TR_TABLE_INSERTUPDATE
   ON BACKOFFICE._TABLE
   AFTER INSERT, UPDATE
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @TabId int;
  DECLARE InsertCursorTable CURSOR
  FOR SELECT DISTINCT SIT_TAB_ID
      FROM inserted;
  OPEN InsertCursorTable;
  FETCH InsertCursorTable INTO @TabId;
  WHILE @@FETCH_STATUS = 0 BEGIN
    SET TAB_UPDATE_AT = GETDATE(),
        TAB_UPDATE_BY = CURRENT_USER,
        TAB_VALID = BACKOFFICE.IS_VALID_TABLE(@TabId) -- BR008 (partial)
    WHERE TAB_ID = @TabId;
    FETCH InsertCursorTable INTO @TabId;
  END;
  CLOSE InsertCursorTable;
  DEALLOCATE InsertCursorTable;
END
GO

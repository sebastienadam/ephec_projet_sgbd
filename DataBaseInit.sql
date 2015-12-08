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
CREATE TABLE BACKOFFICE._RECEPTION (
  REC_ID int IDENTITY(1,1) NOT NULL,
  REC_NAME varchar(64) NOT NULL,
  REC_DATE datetime2 NOT NULL,
  REC_DATE_CLOSING_REG datetime2 NOT NULL,
  REC_CAPACITY int NOT NULL,
  REC_SEAT_TABLE int NOT NULL,
  REC_VALID bit NOT NULL DEFAULT(0), -- BR003, BR006 (partial)
  REC_UPDATE_AT datetime2 NOT NULL,
  REC_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_RECEPTION PRIMARY KEY (REC_ID)
);
CREATE TABLE BACKOFFICE._CLIENT(
  CLI_ID int IDENTITY(1,1) NOT NULL,
  CLI_ACRONYM char(8) NOT NULL,
  CLI_FNAME varchar(64) NOT NULL,
  CLI_LNAME varchar(64) NOT NULL,
  CLI_SEX char(1) NOT NULL,
  CLI_BDAY date NOT NULL,
  CLI_JOB date NOT NULL,
  CLI_UPDATE_AT datetime2 NOT NULL,
  CLI_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_CLIENT PRIMARY KEY (CLI_ID),
  CONSTRAINT UK_CLIENT_ACRONYM UNIQUE (CLI_ACRONYM),
  CONSTRAINT UK_CLIENT_FIRST_LAST_NAME UNIQUE (CLI_FNAME, CLI_LNAME) -- BR0012
);
CREATE TABLE BACKOFFICE._TABLE (
  TAB_ID int IDENTITY(1,1) NOT NULL,
  TAB_SEATING int NOT NULL,
  TAB_REC_ID int NOT NULL,
  TAB_UPDATE_AT datetime2 NOT NULL,
  TAB_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_TABLE PRIMARY KEY (TAB_ID)
);
CREATE TABLE BACKOFFICE._DISH (
  DIS_ID int IDENTITY(1,1) NOT NULL,
  DIS_NAME varchar(64) NOT NULL,
  DIS_TYPE int NOT NULL,
  DIS_UPDATE_AT datetime2 NOT NULL,
  DIS_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_DISH PRIMARY KEY (DIS_ID)
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
CREATE TABLE BACKOFFICE._BOOK (
  BOO_REC_ID int NOT NULL,
  BOO_CLI_ID int NOT NULL,
  BOO_VALID bit NOT NULL DEFAULT(0), -- BR004 
  BOO_UPDATE_AT datetime2 NOT NULL,
  BOO_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_BOOK PRIMARY KEY (BOO_REC_ID,BOO_CLI_ID) -- BR009
);
CREATE TABLE BACKOFFICE._SIT (
  SIT_TAB_ID int NOT NULL,
  SIT_CLI_ID int NOT NULL,
  SIT_UPDATE_AT datetime2 NOT NULL,
  SIT_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_SIT PRIMARY KEY (SIT_TAB_ID,SIT_CLI_ID) -- BR010
);
CREATE TABLE BACKOFFICE._OFFER (
  OFF_REC_ID int NOT NULL,
  OFF_DIS_ID int NOT NULL,
  OFF_UPDATE_AT datetime2 NOT NULL,
  OFF_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_OFFER PRIMARY KEY (OFF_REC_ID,OFF_DIS_ID) -- BR016
);
CREATE TABLE BACKOFFICE._FEEL_CLI_CLI (
  CFC_CLI_ID int NOT NULL,
  CFC_CLI_CLI_ID int NOT NULL,
  CFC_FTY_ID int NOT NULL,
  CFC_UPDATE_AT datetime2 NOT NULL,
  CFC_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_FEEL_CLI_CLI PRIMARY KEY (CFC_CLI_ID,CFC_CLI_CLI_ID) -- BR002
);
CREATE TABLE BACKOFFICE._FEEL_CLI_DIS (
  CFD_CLI_ID int NOT NULL,
  CFD_DIS_ID int NOT NULL,
  CFD_FTY_ID int NOT NULL,
  CFD_UPDATE_AT datetime2 NOT NULL,
  CFD_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_FEEL_CLI_DIS PRIMARY KEY (CFD_CLI_ID,CFD_DIS_ID) -- BR001
);
CREATE TABLE BACKOFFICE._CHOOSE (
  CCD_CLI_ID int NOT NULL,
  CCD_DIS_ID int NOT NULL,
  CCD_REC_ID int NOT NULL,
  CCD_UPDATE_AT datetime2 NOT NULL,
  CCD_UPDATE_BY char(8) NOT NULL,
  CONSTRAINT PK_CHOOSE PRIMARY KEY (CCD_CLI_ID,CCD_DIS_ID, CCD_REC_ID) -- BR017
);
ALTER TABLE BACKOFFICE._TABLE ADD CONSTRAINT FK_TABLE_RECEPTION FOREIGN KEY (TAB_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._DISH ADD CONSTRAINT FK_DISH_TYPE FOREIGN KEY (DIS_TYPE) REFERENCES BACKOFFICE._DISHTYPE (DTY_ID);
ALTER TABLE BACKOFFICE._BOOK ADD CONSTRAINT FK_BOOK_REC FOREIGN KEY (BOO_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._BOOK ADD CONSTRAINT FK_BOOK_CLI FOREIGN KEY (BOO_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._SIT ADD CONSTRAINT FK_SIT_TAB FOREIGN KEY (SIT_TAB_ID) REFERENCES BACKOFFICE._TABLE (TAB_ID);
ALTER TABLE BACKOFFICE._SIT ADD CONSTRAINT FK_SIT_CLI FOREIGN KEY (SIT_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._OFFER ADD CONSTRAINT FK_OFFER_REC FOREIGN KEY (OFF_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);
ALTER TABLE BACKOFFICE._OFFER ADD CONSTRAINT FK_OFFER_DIS FOREIGN KEY (OFF_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_CLI1 FOREIGN KEY (CFC_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_CLI2 FOREIGN KEY (CFC_CLI_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_CLI ADD CONSTRAINT FK_FEEL_CLI_CLI_FEELINGTYPE FOREIGN KEY (CFC_FTY_ID) REFERENCES BACKOFFICE._FEELINGTYPE (FTY_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_CLI FOREIGN KEY (CFD_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_DISH FOREIGN KEY (CFD_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._FEEL_CLI_DIS ADD CONSTRAINT FK_FEEL_CLI_DIS_FEELINGTYPE FOREIGN KEY (CFD_FTY_ID) REFERENCES BACKOFFICE._FEELINGTYPE (FTY_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_CLI FOREIGN KEY (CCD_CLI_ID) REFERENCES BACKOFFICE._CLIENT (CLI_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_DIS FOREIGN KEY (CCD_DIS_ID) REFERENCES BACKOFFICE._DISH (DIS_ID);
ALTER TABLE BACKOFFICE._CHOOSE ADD CONSTRAINT FK_CHOOSE_REC FOREIGN KEY (CCD_REC_ID) REFERENCES BACKOFFICE._RECEPTION (REC_ID);

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

-- ========================================================================== --
--   Vues                                                                     --
-- ========================================================================== --



-- ========================================================================== --
--   Procédures stockées                                                      --
-- ========================================================================== --



-- ========================================================================== --
--   Triggers                                                                 --
-- ========================================================================== --

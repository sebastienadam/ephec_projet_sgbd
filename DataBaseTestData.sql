USE ProjetSGBD;
GO
INSERT INTO BACKOFFICE._RECEPTION (REC_NAME, REC_DATE, REC_DATE_CLOSING_REG, REC_CAPACITY, REC_SEAT_TABLE)
VALUES ('Réception 1', GETDATE(), GETDATE()-1, 250, 6),
       ('Réception 2', GETDATE()+4, GETDATE()+3, 250, 6),
       ('Réception 3', GETDATE()+8, GETDATE()+7, 250, 6),
       ('Réception 4', GETDATE()+12, GETDATE()+11, 250, 6),
       ('Réception 5', GETDATE()+16, GETDATE()+15, 250, 6);
INSERT INTO BACKOFFICE._DISH (DIS_NAME, DIS_TYPE)
VALUES ('Entrée 1', 1),
       ('Entrée 2', 1),
       ('Entrée 3', 1),
       ('Entrée 4', 1),
       ('Plat principal 1', 2),
       ('Plat principal 2', 2),
       ('Plat principal 3', 2),
       ('Plat principal 4', 2),
       ('Dessert 1', 3),
       ('Dessert 2', 3),
       ('Dessert 3', 3),
       ('Dessert 4', 3);
INSERT INTO BACKOFFICE._OFFER (OFF_REC_ID, OFF_DIS_ID)
VALUES (1,1),
       (1,5),
       (1,9),
       (2,1),
       (2,3),
       (2,5),
       (2,7);
INSERT INTO BACKOFFICE._CLIENT (CLI_ACRONYM, CLI_FNAME, CLI_LNAME, CLI_SEX, CLI_BDAY, CLI_JOB)
VALUES ('nompren1', 'Prénom 1', 'NomHomme 1', 'm', '1970-01-01', 'Profession 1'),
       ('nompren2', 'Prénom 2', 'NomFemme 2', 'F', '1972-02-02', 'Profession 2'),
       ('nompren3', 'Prénom 3', 'NomFemme 3', 'f', '1973-03-03', 'Profession 3'),
       ('nompren4', 'Prénom 4', 'NomHomme 4', 'M', '1974-04-04', 'Profession 4'),
       ('nompren5', 'Prénom 5', 'NomHomme 5', 'M', '1975-05-05', 'Profession 5'),
       ('nompren6', 'Prénom 6', 'NomFemme 6', 'f', '1975-06-06', 'Profession 6');
INSERT INTO BACKOFFICE._FEEL_CLI_CLI (CFC_CLI_ID, CFC_CLI_CLI_ID, CFC_FTY_ID)
VALUES (1,2,1),
       (1,3,1),
       (1,4,1),
       (2,3,2),
       (2,4,1),
       (3,4,1),
       (4,1,2),
       (4,2,2),
       (5,4,1),
       (6,4,1);
SELECT * FROM BACKOFFICE._CLIENT;
SELECT * FROM BACKOFFICE._DISH;
SELECT * FROM BACKOFFICE._OFFER;
SELECT * FROM BACKOFFICE._RECEPTION;

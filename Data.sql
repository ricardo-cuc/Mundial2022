USE MundialClubes
SELECT * FROM USUARIOS
select * from equipo
SELECT * FROM PARTIDO
SELECT * FROM FASE

SELECT * FROM APUESTAS_USUARIOS
ORDER BY U_CODIGO DESC

UPDATE USUARIOS
SET U_PASSWORD='000'
WHERE U_CODIGO=12

CREATE TABLE FASE
(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
NOMBRE VARCHAR(50)
)
INSERT INTO FASE
VALUES
('FASE DE GRUPOS'),
('OCTAVOS DE FINAL'),
('CUARTOS DE FINAL'),
('SEMIFINAL'),
('FINAL')

ALTER TABLE EQUIPO
ADD URL_BANDERA VARCHAR(MAX);

ALTER TABLE PARTIDO
ADD FECHA DATETIME;
ALTER TABLE PARTIDO
ADD ID_FASE INT;
ALTER TABLE PARTIDO
ADD C_GRUPO CHAR(1)
ALTER TABLE PARTIDO
ADD FOREIGN KEY (ID_FASE) REFERENCES FASE(ID);

INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA,ID_FASE)
VALUES('7','IN','IR',0,0,'21-11-2022 07:00:00',1)

	

UPDATE EQUIPO
SET URL_BANDERA='https://flagcdn.com/40x30/qa.png'
WHERE C_EQUIPO='QA'
UPDATE EQUIPO
SET URL_BANDERA='https://flagcdn.com/40x30/ec.png'
WHERE C_EQUIPO='EC'
UPDATE EQUIPO
SET URL_BANDERA='https://flagcdn.com/40x30/gb-eng.png'
WHERE C_EQUIPO='IN'
UPDATE EQUIPO
SET URL_BANDERA='https://flagcdn.com/40x30/ir.png'
WHERE C_EQUIPO='IR'
UPDATE EQUIPO
SET URL_BANDERA='https://flagcdn.com/40x30/nl.png'
WHERE C_EQUIPO='NL'
UPDATE EQUIPO
SET URL_BANDERA='https://flagcdn.com/40x30/sn.png'
WHERE C_EQUIPO='SE'

set dateformat dmy;
INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(1,'QA','EC',0,0,'20-11-2022 10:00:00',1)
INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(2,'SE','NL',0,0,'21-11-2022 10:00:00',1)
INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(3,'QA','SE',0,0,'25-11-2022 07:00:00',1)
INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(4,'NL','EC',0,0,'25-11-2022 10:00:00',1)	
INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(5,'EC','SE',0,0,'29-11-2022 09:00:00',1)	
INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(6,'NL','QA',0,0,'29-11-2022 09:00:00',1)	


INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(6,'NL','QA',0,0,'29-11-2022 09:00:00',1)	

INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(6,'EC','QA',0,0,'29-11-2022 09:00:00',2)	

INSERT INTO PARTIDO
(NRO_PARTIDO,C_EQUIPO_1,C_EQUIPO_2,Q_GOLES_E1,Q_GOLES_E2,FECHA, ID_FASE)
VALUES(6,'QA','QA',0,0,'29-11-2022 09:00:00',3)	

SP_HELP'APUESTAS_USUARIOS'
SP_HELP'USUARIOS'

delete APUESTAS_USUARIOS

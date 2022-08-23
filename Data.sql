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


SP_HELP'APUESTAS_USUARIOS'
SP_HELP'USUARIOS'

delete APUESTAS_USUARIOS
----------------------------------Estadios---------------------------------------------------
INSERT INTO [dbo].[ESTADIO]([C_ESTADIO],[N_ESTADIO]) VALUES ('AJ','Al Janoub')
INSERT INTO [dbo].[ESTADIO]([C_ESTADIO],[N_ESTADIO]) VALUES ('CE','Ciudad de la Educación')
INSERT INTO [dbo].[ESTADIO]([C_ESTADIO],[N_ESTADIO]) VALUES ('ABA','Ahmad Bin Ali')
INSERT INTO [dbo].[ESTADIO]([C_ESTADIO],[N_ESTADIO]) VALUES ('AT','Al Thumama')
INSERT INTO [dbo].[ESTADIO]([C_ESTADIO],[N_ESTADIO]) VALUES ('EIK','Estadio Internacional Khalifa')
INSERT INTO [dbo].[ESTADIO]([C_ESTADIO],[N_ESTADIO]) VALUES ('AB','Al Bayt')
INSERT INTO [dbo].[ESTADIO]([C_ESTADIO],[N_ESTADIO]) VALUES ('974','974')
INSERT INTO [dbo].[ESTADIO]([C_ESTADIO],[N_ESTADIO]) VALUES ('L','Lusail')

----------------------------------Insert Equipos---------------------------------------------

INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(1,'AR','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(2,'AU','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(3,'BE','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(4,'BR','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(5,'CA','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(6,'CH','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(7,'CM','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(8,'CR','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(9,'DE','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(10,'DK','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(11,'EC','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(12,'ES','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(13,'FR','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(14,'GH','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(15,'GL','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(16,'GT','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(17,'HR','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(18,'IN','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(19,'IR','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(20,'JP','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(21,'KR','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(22,'MA','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(23,'MX','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(24,'NL','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(25,'PL','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(26,'PT','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(27,'QA','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(28,'SA','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(29,'SE','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(30,'TN','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(31,'US','M22',0)
INSERT INTO [dbo].[EQUIPOS_CAMPEONATO] ([E_C_ID], [C_EQUIPO], [C_CAMPEONATO], [E_TOTAL_PUNTOS]) VALUES(32,'UY','M22',0)

-------------------------------------Insertar Partidos------------------------------
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(2,'AT','SE','NL','M22','21/11/2022 4:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','21/11/2022 4:00',1,'A')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(3,'K','IN','IR','M22','21/11/2022 7:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','21/11/2022 7:00',1,'B')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(4,'AB','US','GL','M22','21/11/2022 10:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','21/11/2022 10:00',1,'B')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(5,'L','AR','SA','M22','22/11/2022 4:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','22/11/2022 4:00',1,'C')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(6,'CE','DK','TN','M22','22/11/2022 7:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','22/11/2022 7:00',1,'D')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(7,'974','MX','PL','M22','22/11/2022 10:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','22/11/2022 10:00',1,'C')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(8,'AJ','FR','AU','M22','22/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','22/11/2022 13:00',1,'D')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(9,'AB','MA','HR','M22','23/11/2022 4:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','23/11/2022 4:00',1,'F')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(10,'K','DE','JP','M22','23/11/2022 7:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','23/11/2022 7:00',1,'E')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(11,'AT','ES','CR','M22','23/11/2022 10:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','23/11/2022 10:00',1,'E')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(12,'ABA','BE','CA','M22','23/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','23/11/2022 13:00',1,'F')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(13,'AJ','CH','CM','M22','24/11/2022 4:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','24/11/2022 4:00',1,'G')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(14,'CE','UY','KR','M22','24/11/2022 7:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','24/11/2022 7:00',1,'H')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(15,'974','PT','GH','M22','24/11/2022 10:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','24/11/2022 10:00',1,'H')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(16,'L','BR','RS','M22','24/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','24/11/2022 13:00',1,'G')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(17,'ABA','GL','IR','M22','25/11/2022 4:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','25/11/2022 4:00',6,'B')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(18,'AT','QA','SE','M22','25/11/2022 7:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','25/11/2022 7:00',6,'A')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(19,'K','NL','EC','M22','25/11/2022 10:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','25/11/2022 10:00',6,'A')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(20,'AB','IN','US','M22','25/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','25/11/2022 13:00',6,'B')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(21,'ABA','TN','AU','M22','26/11/2022 4:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','26/11/2022 4:00',6,'D')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(22,'CE','PL','SA','M22','26/11/2022 7:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','26/11/2022 7:00',6,'C')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(23,'974','FR','DK','M22','26/11/2022 10:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','26/11/2022 10:00',6,'D')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(24,'L','AR','MX','M22','26/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','26/11/2022 13:00',6,'C')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(25,'ABA','JP','CR','M22','27/11/2022 4:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','27/11/2022 4:00',6,'E')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(26,'AT','BE','MA','M22','27/11/2022 7:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','27/11/2022 7:00',6,'F')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(27,'K','HR','CA','M22','27/11/2022 10:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','27/11/2022 10:00',6,'F')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(28,'AB','ES','DE','M22','27/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','27/11/2022 13:00',6,'E')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(29,'AJ','CM','RS','M22','28/11/2022 4:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','28/11/2022 4:00',6,'G')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(30,'CE','KR','GH','M22','28/11/2022 7:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','28/11/2022 7:00',6,'H')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(31,'974','BR','CH','M22','28/11/2022 10:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','28/11/2022 10:00',6,'G')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(32,'L','PT','UY','M22','28/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','28/11/2022 13:00',6,'H')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(33,'AB','NL','QA','M22','29/11/2022 9:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','29/11/2022 9:00',7,'A')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(34,'K','EC','SE','M22','29/11/2022 9:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','29/11/2022 9:00',7,'A')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(35,'ABA','GL','IN','M22','29/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','29/11/2022 13:00',7,'B')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(36,'AT','IR','US','M22','29/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','29/11/2022 13:00',7,'B')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(37,'CE','TN','FR','M22','30/11/2022 9:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','30/11/2022 9:00',7,'D')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(38,'AJ','AU','DK','M22','30/11/2022 9:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','30/11/2022 9:00',7,'D')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(39,'L','SA','MX','M22','30/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','30/11/2022 13:00',7,'C')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(40,'974','PL','AR','M22','30/11/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','30/11/2022 13:00',7,'C')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(41,'ABA','HR','BE','M22','01/12/2022 9:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','01/12/2022 9:00',7,'F')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(42,'AT','CA','MA','M22','01/12/2022 9:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','01/12/2022 9:00',7,'F')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(43,'K','JP','ES','M22','01/12/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','01/12/2022 13:00',7,'E')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(44,'AB','CR','DE','M22','01/12/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','01/12/2022 13:00',7,'E')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(45,'AJ','GH','UY','M22','02/12/2022 9:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','02/12/2022 9:00',7,'H')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(46,'CE','KR','PT','M22','02/12/2022 9:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','02/12/2022 9:00',7,'H')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(47,'974','RS','CH','M22','02/12/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','02/12/2022 13:00',7,'G')
INSERT INTO [dbo].[PARTIDO] ([NRO_PARTIDO], [C_ESTADIO_PART], [C_EQUIPO_1], [C_EQUIPO_2], [C_CAMPEONATO], [D_PARTIDO], [N_JUEZ_LINEA1], [N_JUEZ_LINEA2], [Q_GOLES_E1], [Q_GOLES_E2], [N_ARBITRO], [E_PARTIDO], [FECHA], [ID_FASE], [C_GRUPO]) VALUES(48,'L','CM','BR','M22','02/12/2022 13:00','JUEZ LINEA 1','JUEZ LINEA 2',0,0,'NOMBRE ARBITRO','SIN INICIAR','02/12/2022 13:00',7,'G')

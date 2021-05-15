----------CURSOS----------

--Para el atributo IsActive:
--0: Inactivo
--1: Activo

--Para el atributo Cycle:
--1: I Semestre
--2: II Semestre
--3: Verano

-----------I CICLO-----------
INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('EG', 'CURSO DE ARTE', 1, 2, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('EG-I', 'CURSO INTEGRADO DE HUMANIDADES I', 1, 6, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF1300', 'INTRODUCCI�N A LA COMPUTACI�N E INFORM�TICA', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF1400', 'L�GICA PARA INFORM�TICOS', 1, 2, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('LM1030', 'ESTRATEGIAS DE LECTURA EN INGL�S I', 1, 4, 1)

-----------II CICLO-----------
INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('EF', 'ACTIVIDAD DEPORTIVA', 1, 0, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('EG-II', 'CURSO INTEGRADO DE HUMANIDADES II', 0, 6, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF2000', 'PROGRAMACI�N I', 0, 4, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('LM1032', 'ESTRATEGIAS DE LECTURA EN INGL�S II', 0, 4, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('MA0320', 'ESTRUCTURAS MATEM�TICAS DISCRETAS', 0, 4, 2)

-----------III CICLO-----------
INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF3000', 'PROGRAMACI�N II', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF3001', 'ALGORITMOS Y ESTRUCTURAS DE DATOS', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF3100', 'INTRODUCCI�N A SISTEMAS DE INFORMACI�N', 1, 3, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('MA0321', 'C�LCULO DIFERENCIAL E INTEGRAL', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('XS0105', 'ESTAD�STICA PARA INFORM�TICOS', 1, 3, 1)

-----------IV CICLO-----------
INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF4000', 'ARQUITECTURA DE COMPUTADORES', 0, 3, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF4001', 'SISTEMAS OPERATIVOS', 0, 4, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF4100', 'FUNDAMENTOS DE BASES DE DATOS', 0, 4, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF5200', 'FUNDAMENTOS DE LAS ORGANIZACIONES', 0, 3, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('MA0322', '�LGEBRA LINEAL', 0, 4, 2)

-----------V CICLO-----------
INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF4101', 'LENGUAJES PARA APLICACIONES COMERCIALES', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF5000', 'REDES Y COMUNICACIONES DE DATOS', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF5100', 'ADMINISTRACI�N DE BASES DE DATOS', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('MA0323', 'M�TODOS NUM�RICOS', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('SR-I', 'SEMINARIO DE REALIDAD NACIONAL I', 1, 2, 1)

-----------VI CICLO-----------
INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF6000', 'REDES EN LOS NEGOCIOS', 0, 4, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF6100', 'AN�LISIS Y DISE�O DE SISTEMAS', 0, 4, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF6200', 'ECONOM�A DE LA COMPUTACI�N', 0, 3, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF6201', 'INFORM�TICA APLICADA A LOS NEGOCIOS', 0, 3, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('SR-II', 'SEMINARIO DE REALIDAD NACIONAL II', 0, 2, 2)

-----------VII CICLO-----------
INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF7100', 'INGENIER�A DE SOFTWARE', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF7101', 'COMPROMISO SOCIAL DE LA INFORM�TICA', 1, 2, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF7200', 'M�TODOS CUANTITATIVOS PARA LA TOMA DE DECISIONES', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF7201', 'GESTI�N DE PROYECTOS', 1, 4, 1)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('OPT453', 'OPTATIVO DE TEMAS ESPECIALES', 1, 3, 1)

-----------VIII CICLO-----------
INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF8100', 'PR�CTICA EMPRESARIAL SUPERVISADA', 1, 6, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF8200', 'AUDITOR�A INFORM�TICA', 0, 4, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('IF8201', 'PLANIFICACI�N INFORM�TICA', 0, 4, 2)

INSERT INTO Course (Initials, Name, IsActive, Credits, Cycle)
VALUES ('RP-1', 'REPERTORIO', 1, 3, 2)}

SELECT * FROM Course
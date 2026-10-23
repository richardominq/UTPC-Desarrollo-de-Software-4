-- Ejecutar en SSMS con autenticación de Windows.
-- El script se puede repetir sin borrar datos ni duplicar las filas iniciales.
USE master;

IF DB_ID(N'CrudWindowsForms') IS NULL
    CREATE DATABASE CrudWindowsForms;

USE CrudWindowsForms;

-- SSMS puede continuar después de un error en otro bloque GO.
-- No crear ni consultar tablas si USE no seleccionó la base del laboratorio.
IF DB_NAME() <> N'CrudWindowsForms'
    THROW 50001, 'No se pudo seleccionar CrudWindowsForms. Revise la conexion y la creacion de la base.', 1;

IF OBJECT_ID(N'dbo.People', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.People (
        Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Name VARCHAR(100) NOT NULL,
        Age INT NOT NULL
    );
    INSERT INTO dbo.People (Name, Age)
    VALUES ('Ana', 20), ('Luis', 25), ('Maria', 22);
END;
GO
IF DB_NAME() <> N'CrudWindowsForms'
    THROW 50001, 'No se pudo seleccionar CrudWindowsForms. Revise la conexion y la creacion de la base.', 1;

SELECT Id, Name, Age FROM dbo.People ORDER BY Id;
GO

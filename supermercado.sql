/* Crear la Base de Datos Recreación */
USE MASTER
GO
/****** Object:  Database [RECREACION]    ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'AlmacenCs')
BEGIN
	CREATE DATABASE AlmacenCs
END
go
/* Poner en uso la Base de Datos */
use AlmacenCs
go

/* Crear la Tabla Categoria*/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categoria]') AND type in (N'U'))
BEGIN
CREATE TABLE Categoria(
CodCat Int IDENTITY(1,1) PRIMARY KEY,
NomCat varchar(30) NOT NULL);
END
GO
/* Crear la Tabla Producto */
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Producto]') AND type in (N'U'))
BEGIN
CREATE TABLE Producto(
CodProd Int IDENTITY(1,1) PRIMARY KEY,
NomProd varchar(30) NOT NULL,
CodCat Int NOT NULL);
END
/* Datos para la tabla Categoria */
INSERT INTO Categoria(NomCat) VALUES('Lacteos');
INSERT INTO Categoria(NomCat) VALUES('Granos');
INSERT INTO Categoria(NomCat) VALUES('Carnes');
INSERT INTO Categoria(NomCat) VALUES('Bebidas');
INSERT INTO Categoria(NomCat) VALUES('Aseo');


/*Datos para la tabla Producto */
INSERT INTO Producto(NomProd,CodCat) VALUES('Leche',1);
INSERT INTO Producto(NomProd,CodCat) VALUES('Arroz',2);
INSERT INTO Producto(NomProd,CodCat) VALUES('Queso',1);
INSERT INTO Producto(NomProd,CodCat) VALUES('Pollo',3);
INSERT INTO Producto(NomProd,CodCat) VALUES('Gaseosa',4);
INSERT INTO Producto(NomProd,CodCat) VALUES('Jabón',5);
INSERT INTO Producto(NomProd,CodCat) VALUES('Frijol',2);
INSERT INTO Producto(NomProd,CodCat) VALUES('Crema dental',5);
INSERT INTO Producto(NomProd,CodCat) VALUES('Jamón',3);
INSERT INTO Producto(NomProd,CodCat) VALUES('Tequila',4);
INSERT INTO Producto(NomProd,CodCat) VALUES('Kumis',1);


SELECT NomCat,NomProd FROM Categoria,Producto WHERE Categoria.CodCat=Producto.CodCat;




CREATE PROCEDURE pa_Categoria
AS
BEGIN
SELECT * FROM  Categoria;
END 
GO
EXECUTE pa_Categoria



CREATE PROCEDURE pa_Producto
AS
BEGIN
SELECT * FROM Producto;
END 
GO 
EXECUTE pa_Producto

CREATE PROCEDURE pa_Inicial
@Pincial varchar (30)
AS
BEGIN
SELECT * FROM Producto WHERE NomProd like @Pincial +'%'
END
GO

CREATE PROCEDURE pa_Nombre
AS
BEGIN
SELECT NomCat FROM Categoria
END
GO

CREATE PROCEDURE pa_Clacteos
@Codigo int
AS
BEGIN
SELECT * FROM Producto WHERE CodCat=@Codigo
END
GO

CREATE PROCEDURE pa_Cgranos
@codigo int 
AS 
BEGIN
SELECT * FROM Producto WHERE CodCat=@codigo
END
GO

CREATE PROCEDURE pa_Ccarnes
@codigo int 
AS
BEGIN
SELECT * FROM Producto WHERE CodCat=@codigo
END
GO

CREATE PROCEDURE pa_CBebidas
@codigo int 
AS
BEGIN
SELECT * FROM Producto WHERE CodCat=@codigo
ENd
GO

CREATE PROCEDURE pa_CAseo
@codigo int 
AS
BEGIN
SELECT * FROM Producto WHERE CodCat=@codigo
END
GO

CREATE PROCEDURE pa_Pasc
AS
BEGIN
SELECT * FROM Producto ORDER BY CodProd ASC
END
GO

CREATE PROCEDURE pa_Nasc
AS
BEGIN
SELECT * FROM Producto ORDER BY NomProd ASC
END 
GO

CREATE PROCEDURE pa_Casc
AS
BEGIN
SELECT * FROM Producto ORDER BY CodCat ASC
END
GO


CREATE PROCEDURE pa_Pdsc
AS
BEGIN
SELECT * FROM Producto ORDER BY CodProd DESC
END
GO

CREATE PROCEDURE pa_Ndsc
AS
BEGIN
SELECT * FROM Producto ORDER BY NomProd  DESC
END
GO

CREATE PROCEDURE pa_Cdsc
AS
BEGIN
SELECT * FROM Producto ORDER BY CodCat  DESC
END
GO

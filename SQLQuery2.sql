USE MASTER 
GO
BEGIN
CREATE DATABASE PruebaSaber
END

CREATE TABLE Prueba (
Nombre VARCHAR (30) NOT NULL,
Apellido VARCHAR (30) NOT NULL,
Correo VARCHAR (30) NOT NULL,
Contrase�a VARCHAR (30) NOT NULL,
CodigoUs int IDENTITY (1,1) PRIMARY KEY )

CREATE PROCEDURE pa_Registro
@Nombre VARCHAR (30),
@Apellido VARCHAR (30),
@Correo VARCHAR (30),
@Contrase�a VARCHAR (30)
AS
BEGIN
INSERT INTO Prueba (Nombre, Apellido, Correo, Contrase�a)
       VALUES (@Nombre, @Apellido, @Correo, @Contrase�a)
END 
GO

CREATE PROCEDURE pa_LoginU
@correo VARCHAR (30)
AS
BEGIN
SELECT * FROM Prueba WHERE Correo =@correo  
END
GO

CREATE PROCEDURE pa_LoginC
@contrase�a VARCHAR (30)
AS
BEGIN
SELECT * FROM Prueba WHERE Contrase�a=@contrase�a
END
GO

CREATE PROCEDURE pa_Mostrar
@nombre varchar (30)
as
begin
select *from Prueba where Nombre=@nombre
end 
go
exec pa_Mostrar 'Yesica'

ALTER PROCEDURE pa_M
@Nombre varchar (30)
as
begin
select *from Prueba where Correo=@Nombre
end 
go



--Base de datos para practica programada 1
CREATE DATABASE PracticaProgramada1;
GO


USE PracticaProgramada1;
GO

CREATE TABLE Personas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Identificación VARCHAR(20) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    PrimerApellido VARCHAR(50) NOT NULL,
    SegundoApellido VARCHAR(50) NOT NULL
);
GO

--Procedimiento almacenado para listar las personas que existan.
CREATE PROCEDURE [dbo].[sp_GetAllPersonas]
AS
BEGIN
    -- Evita que se generen conjuntos de resultados adicionales
    SET NOCOUNT ON;

    -- Sentencia de selección para el procedimiento
    SELECT * FROM Personas p
    ORDER BY p.Id DESC;

END
GO


--Procedimiento para crear personas en la base de datos.
CREATE PROCEDURE sp_AddPersona
    @Identificacion varchar(20),
    @Nombre varchar(50),
    @PrimerApellido varchar(50),
    @SegundoApellido varchar(50)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    INSERT INTO Personas (Identificación, Nombre, PrimerApellido, SegundoApellido)
    VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido);

    /*
    Más código fuente aquí si es necesario
    */
END
GO

--Procedimiento para editar personas en la base de datos.
CREATE PROCEDURE [dbo].[sp_UpdatePersona]
    @Id INT,
    @Identificación VARCHAR(20),
    @Nombre VARCHAR(50),
    @PrimerApellido VARCHAR(50),
    @SegundoApellido VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Personas
    SET Identificación = @Identificación,
        Nombre = @Nombre,
        PrimerApellido = @PrimerApellido,
        SegundoApellido = @SegundoApellido
    WHERE Id = @Id;
END
GO


--Procedimiento para eliminar personas en la base de datos.
CREATE PROCEDURE [dbo].[sp_DeletePersona]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Personas
    WHERE Id = @Id;
END
GO


Scaffold-DbContext "Server=Marcel\MSSQLSERVER01;Database=PracticaProgramada1;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Abstracciones -Force


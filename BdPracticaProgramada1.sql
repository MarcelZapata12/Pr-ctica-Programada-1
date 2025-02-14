--Base de datos para practica programada 1
CREATE DATABASE PracticaProgramada1;
GO


USE PracticaProgramada1;
GO

CREATE TABLE Personas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Identificaci�n VARCHAR(20) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    PrimerApellido VARCHAR(50) NOT NULL,
    SegundoApellido VARCHAR(50) NOT NULL
);
GO

--Procedimiento almacenado para listar las personas que existan.
CREATE PROCEDURE ListarPersonas
AS
BEGIN
    SELECT * FROM Personas;
END;
GO

--Procedimiento para crear personas en la base de datos.
CREATE PROCEDURE CrearPersona
    @Identificaci�n VARCHAR(20),
    @Nombre VARCHAR(50),
    @PrimerApellido VARCHAR(50),
    @SegundoApellido VARCHAR(50)
AS
BEGIN
    INSERT INTO Personas (Identificaci�n, Nombre, PrimerApellido, SegundoApellido)
    VALUES (@Identificaci�n, @Nombre, @PrimerApellido, @SegundoApellido);
END;
GO

--Procedimiento para editar personas en la base de datos.
CREATE PROCEDURE ModificarPersona
    @Id INT,
    @Identificaci�n VARCHAR(20),
    @Nombre VARCHAR(50),
    @PrimerApellido VARCHAR(50),
    @SegundoApellido VARCHAR(50)
AS
BEGIN
    UPDATE Personas
    SET Identificaci�n = @Identificaci�n,
        Nombre = @Nombre,
        PrimerApellido = @PrimerApellido,
        SegundoApellido = @SegundoApellido
    WHERE Id = @Id;
END;
GO

--Procedimiento para eliminar personas en la base de datos.
CREATE PROCEDURE EliminarPersona
    @Id INT
AS
BEGIN
    DELETE FROM Personas
    WHERE Id = @Id;
END;
GO



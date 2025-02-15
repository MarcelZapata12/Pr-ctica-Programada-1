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
    INSERT INTO Personas (Identificacion, Nombre, PrimerApellido, SegundoApellido)
    VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido);

    /*
    Más código fuente aquí si es necesario
    */
END
GO
DROP PROCEDURE sp_AddPersona;
GO

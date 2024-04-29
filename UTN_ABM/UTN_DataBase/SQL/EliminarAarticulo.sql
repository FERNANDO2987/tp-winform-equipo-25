USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[EliminarArticulo]    Script Date: 28/04/2024 21:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarArticulo]
(
    @IdArticulo INT
)
AS
BEGIN
    -- Verificar si el artículo existe
    IF EXISTS (SELECT 1 FROM ARTICULOS WHERE Id = @IdArticulo)
    BEGIN
        -- Eliminar las imágenes asociadas al artículo
        DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo

        -- Eliminar el artículo de la tabla ARTICULOS
        DELETE FROM ARTICULOS WHERE Id = @IdArticulo

        PRINT 'Artículo dado de baja correctamente.'
    END
    ELSE
    BEGIN
        PRINT 'El artículo especificado no existe.'
    END
END

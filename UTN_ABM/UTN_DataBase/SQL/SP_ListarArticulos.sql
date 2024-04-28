USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[ListarArticulos]    Script Date: 27/04/2024 11:55:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ListarArticulos]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT [Id],[Codigo],[Nombre],[Descripcion],[IdMarca],[IdCategoria],[Precio]
    FROM [dbo].[ARTICULOS];
END;
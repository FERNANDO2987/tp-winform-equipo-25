USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerCategorias]    Script Date: 24/04/2024 10:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ObtenerCategorias]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT [Id], [Descripcion]
    FROM [dbo].[CATEGORIAS];
END;



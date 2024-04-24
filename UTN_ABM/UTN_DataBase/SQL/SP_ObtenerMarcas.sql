USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerMarcas]    Script Date: 24/04/2024 9:54:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ObtenerMarcas]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT [Id], [Descripcion]
    FROM [dbo].[MARCAS];
END;



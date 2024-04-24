USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[BuscarArticuloPorCriterio]    Script Date: 24/04/2024 9:50:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BuscarArticuloPorCriterio]
    @valorBusqueda varchar(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM ARTICULOS
    WHERE
        Codigo LIKE '%' + @valorBusqueda + '%' OR
        Nombre LIKE '%' + @valorBusqueda + '%' OR
        Descripcion LIKE '%' + @valorBusqueda + '%' OR
        CAST(IdMarca AS varchar(50)) LIKE '%' + @valorBusqueda + '%' OR
        CAST(IdCategoria AS varchar(50)) LIKE '%' + @valorBusqueda + '%' OR
        CAST(Precio AS varchar(50)) LIKE '%' + @valorBusqueda + '%';
END;




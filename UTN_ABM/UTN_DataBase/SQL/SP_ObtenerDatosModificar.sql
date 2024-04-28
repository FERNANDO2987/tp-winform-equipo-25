USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerDatosModificar]    Script Date: 27/04/2024 22:50:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ObtenerDatosModificar]
@criterio varchar(50) = NULL
AS
BEGIN
     SET NOCOUNT ON;

	 SELECT
	 A.Id,
	 A.Codigo,
	 A.Nombre,
	 A.Descripcion,
	 COALESCE(M.Descripcion, 'null') AS Marca,
	 COALESCE(C.Descripcion, 'null') AS Categoria,
	 A.Precio,
	 COALESCE(I.ImagenUrl, 'null') AS ImagenUrl,
	 M.Id,
	 C.Id
	 FROM 
	 ARTICULOS A
	 LEFT JOIN
	 MARCAS M ON A.IdMarca = M.Id
	 LEFT JOIN
	 CATEGORIAS C ON A.IdCategoria = C.Id
	 LEFT JOIN 
	 IMAGENES I ON A.Id = I.IdArticulo
	 WHERE 
	 (
	     A.Nombre LIKE '%' + @criterio + '%'
	     OR
	     COALESCE(M.Descripcion, 'null') LIKE '%' + @criterio + '%'
	     OR
	     COALESCE(C.Descripcion, 'null') LIKE '%' + @criterio + '%'
	     OR
	     CONVERT(varchar(50), A.Precio) LIKE '%' + @criterio + '%'
	     OR
	     COALESCE(I.ImagenUrl, 'null') LIKE '%' + @criterio + '%'
	 );

END;

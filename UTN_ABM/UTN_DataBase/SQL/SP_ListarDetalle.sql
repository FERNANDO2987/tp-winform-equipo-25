USE [CATALOGO_P3_DB]
GO

/****** Object:  Table [dbo].[MARCAS]    Script Date: 25/04/2024 23:17:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarDetalle]
@criterio varchar(50)
AS
BEGIN
     SET NOCOUNT ON;

	 SELECT
	 A.Id,
	 A.Codigo,
	 A.Nombre,
	 A.Descripcion,
	 M.Descripcion AS Marca,
	 C.Descripcion AS Categoria,
	 A.Precio,
	 I.ImagenUrl

	 FROM 
	  ARTICULOS A

	 LEFT JOIN
	 MARCAS M ON A.IdMarca = M.Id

	 LEFT JOIN
	 CATEGORIAS C ON A.IdCategoria = C.Id

	 LEFT JOIN 
	 IMAGENES I ON A.Id = I.IdArticulo

	 WHERE 
	     A.Nombre LIKE '%' + @criterio + '%';

		 END;

		 GO



USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[AgregarArticulo]    Script Date: 25/04/2024 6:49:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarArticulo]
  (  @Id INT,
    @Codigo VARCHAR(50),
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(150),
    @IdMarca INT,
    @IdCategoria INT,
    @Precio MONEY
  ) 
AS BEGIN

     	if (EXISTS (SELECT * FROM [dbo].[ARTICULOS] WHERE Id = @Id ))
		UPDATE [dbo].[ARTICULOS] SET Codigo = @Codigo,
		                             Nombre = @Nombre,
									 Descripcion= @Descripcion,
									 IdMarca = @IdMarca,
									 IdCategoria = @IdCategoria,
									 Precio = @Precio 
									 WHERE Id = @Id
		else
		    BEGIN

INSERT INTO [dbo].[ARTICULOS]
VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)

       SELECT SCOPE_IDENTITY()
	   END

END


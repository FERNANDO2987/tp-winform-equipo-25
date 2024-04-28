USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[AgregarArticulo]    Script Date: 28/04/2024 06:35:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarCategoria]
  (  @Id INT,
    @Descripcion VARCHAR(50)

  ) 
AS BEGIN

     	if (EXISTS (SELECT * FROM [dbo].[CATEGORIAS] WHERE Id = @Id ))
		UPDATE [dbo].[ARTICULOS] SET 
								Descripcion=@Descripcion
							
									 
									 WHERE Id = @Id
		else
		    BEGIN

INSERT INTO [dbo].[CATEGORIAS]
VALUES (@Descripcion)

       SELECT SCOPE_IDENTITY()
	   END

END


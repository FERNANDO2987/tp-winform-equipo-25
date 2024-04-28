USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[AgregarCategoria]    Script Date: 28/04/2024 20:04:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarMarca]
  (  @Id INT,
    @Descripcion VARCHAR(50)

  ) 
AS BEGIN

     	if (EXISTS (SELECT * FROM [dbo].[MARCAS] WHERE Id = @Id ))
		UPDATE [dbo].[MARCAS] SET 
								Descripcion=@Descripcion
							
									 
									 WHERE Id = @Id
		else
		    BEGIN

INSERT INTO [dbo].[MARCAS]
VALUES (@Descripcion)

       SELECT SCOPE_IDENTITY()
	   END

END


USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[AgregarImagenes]    Script Date: 27/04/2024 10:03:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarImagenes]
  (  @Id INT,
    @IdArticulo INT,
    @ImagenUrl VARCHAR(1000)
   
  ) 
AS BEGIN

     	if (EXISTS (SELECT * FROM [dbo].[IMAGENES] WHERE Id = @Id ))
		UPDATE [dbo].[IMAGENES] SET IdArticulo = @IdArticulo,
		                             ImagenUrl = @ImagenUrl
									 
									 WHERE Id = @Id
		else
		    BEGIN

INSERT INTO [dbo].[IMAGENES]
VALUES (@IdArticulo, @ImagenUrl)

       SELECT SCOPE_IDENTITY()
	   END

END


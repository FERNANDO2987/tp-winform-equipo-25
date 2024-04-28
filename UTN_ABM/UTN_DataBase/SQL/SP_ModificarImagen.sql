USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[AgregarImagenes]    Script Date: 28/04/2024 06:14:05 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ModificarImagen]
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


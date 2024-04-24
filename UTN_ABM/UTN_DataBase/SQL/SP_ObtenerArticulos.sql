USE [CATALOGO_P3_DB]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerArticulos]    Script Date: 24/04/2024 9:52:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerArticulos]

@idArticulos INT

AS
BEGIN 

if(@idArticulos <> 0)
begin

SELECT *FROM [dbo].[ARTICULOS]
WHERE Id = @idArticulos
end
END


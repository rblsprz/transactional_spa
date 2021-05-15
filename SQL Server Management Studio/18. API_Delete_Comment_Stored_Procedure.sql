CREATE PROCEDURE [dbo].[DeleteComment](@id INTEGER)
AS 
  BEGIN 
	DELETE
	FROM Comment
	WHERE id=@id
END 
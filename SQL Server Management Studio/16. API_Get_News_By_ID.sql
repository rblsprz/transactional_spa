CREATE PROCEDURE [dbo].[GetNewsById](@Id INTEGER)
AS 
  BEGIN 
		SELECT Id, AuthorId, AuthorName, DateTime, Text, Title
		FROM News
		WHERE Id = @Id
END 
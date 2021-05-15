CREATE PROCEDURE [dbo].[InsertComment](
						@AuthorId INT,
						@AuthorName VARCHAR(50),
						@Text VARCHAR(500),
						@DateTime VARCHAR(50),
						@NewsId INT)
AS 
  BEGIN 
		INSERT INTO Comment (AuthorId, AuthorName, Text, DateTime, NewsId)
		VALUES(@AuthorId, @AuthorName, @Text, @DateTime, @NewsId)
END
-------------------------------------------------------------------

CREATE PROCEDURE [dbo].[SelectCommentById](@id INTEGER)
AS 
  BEGIN 
	SELECT Id, AuthorId, AuthorName, DateTime, Text, NewsId
	FROM Comment
	WHERE NewsId = @id
	ORDER BY DateTime DESC
END 

-------------------------------------------------------------------
CREATE PROCEDURE SelectComments
AS 
  BEGIN 
	SELECT Id, DateTime, Text, AuthorName, AuthorId, NewsId
	FROM Comment
	ORDER BY DateTime DESC
END 
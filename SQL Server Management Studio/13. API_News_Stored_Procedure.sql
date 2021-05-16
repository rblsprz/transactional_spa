CREATE PROCEDURE [dbo].[SelectNews]
AS 
  BEGIN 
		SELECT Id, AuthorId, AuthorName, DateTime, Text, Title
		FROM News
		ORDER BY DateTime DESC
END 
GO

------------------------------------------------------------

CREATE PROCEDURE [dbo].[SelectNewsByTitle](@title VARCHAR(200))
AS 
  BEGIN 
		SELECT Id, AuthorId, AuthorName, DateTime, Text, Title
		FROM News
		WHERE Title = @title
END 
GO

------------------------------------------------------------

CREATE PROCEDURE [dbo].[InsertUpdateNews](
						@Id INT,
						@Title VARCHAR(200),
						@Text VARCHAR(3000),
						@DateTime VARCHAR(50),
						@AuthorName VARCHAR(50),
						@AuthorId INT,
						@Action VARCHAR(10))
AS 
  BEGIN 
  IF @Action = 'Insert' 
        BEGIN 
			INSERT INTO News (AuthorId,AuthorName,DateTime,Text,title)
			VALUES(@AuthorId,@AuthorName,@DateTime,@Text,@title)
			END 
  IF @Action = 'Update' 
        BEGIN 
			UPDATE News
			SET Title = @Title,
			Text = @Text,
			DateTime = @DateTime,
			AuthorId = @AuthorId,
			AuthorName = @AuthorName
			WHERE Id = @Id
		END
END 
-----------------------------------------------------------

CREATE PROCEDURE DeleteNews (@Id INT)
AS 
  BEGIN 
		DELETE News
		WHERE Id = @Id
END 
GO

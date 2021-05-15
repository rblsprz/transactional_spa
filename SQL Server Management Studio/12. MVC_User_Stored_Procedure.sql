----------TYPE USER VERIFY----------
CREATE PROCEDURE TypeUserVerify (@Id INT)
AS DECLARE @typeUser INT, @StudentId INT, @ProfessorId INT;
  BEGIN 
		SELECT @StudentId = Id
		FROM Student 
		WHERE Id = @Id

		SELECT @ProfessorId = Id
		FROM Professor
		WHERE Id = @Id

		IF @StudentId IS NOT NULL 
		BEGIN
			SET @typeUser = 1
		END

		ELSE IF @ProfessorId IS NOT NULL 
		BEGIN
			SET @typeUser = 2
		END
		ELSE 
		BEGIN
			SET @typeUser = 3
		END
		RETURN @typeUser;
END 

----------LOGIN----------
CREATE PROCEDURE UsersLogin(@Username VARCHAR(50), @Password  VARCHAR(50))
AS DECLARE @Exists INT, @Id INT;
  BEGIN 
		SELECT @Id = Id
		FROM Users 
		WHERE Username = @Username
		AND Password = @Password

		IF @Id IS NOT NULL 
		BEGIN
			SET @Exists = 1
		END
		ELSE 
		BEGIN
			SET @Exists = 0
		END
		RETURN @Exists;
	END 
 
------------------------------------------------
 CREATE PROCEDURE SelectUsers
AS  
  BEGIN 
		SELECT Id, Username, Password, IsAdministrator, Status
		FROM Users
	END 
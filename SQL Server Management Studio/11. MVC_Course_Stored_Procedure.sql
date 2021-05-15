----------CRUD COURSE----------
----------INSERT UPDATE----------

--Para el atributo IsActive:
--0: Inactivo
--1: Activo

--Para el atributo Cycle:
--1: I Semestre
--2: II Semestre
--3: Verano
USE [MVC_IF4101MVCLPAC]
CREATE PROCEDURE InsertUpdateCourse (  @Id INT,
									   @Initials VARCHAR(10),
									   @Name VARCHAR(50),
									   @IsActive INT,
									   @Credits INT,
									   @Cycle INT,
									   @Action VARCHAR(10))

AS 
	BEGIN 
		IF @Action = 'Insert' 
			BEGIN 
			INSERT INTO Course 
						(Initials ,
						Name, 
						 IsActive, 
						 Credits,
						 Cycle) 
			VALUES     (@Initials,
						@Name,
						@IsActive,
						@Credits,
						@Cycle); 

			
		END 
	  IF @Action = 'Update' 
		BEGIN 
			
			UPDATE Course 
			SET    Initials = @Initials,
				   Name = @Name,
				   IsActive = @IsActive,
				   Credits = @Credits,
				   Cycle = @Cycle
			WHERE  Id = @Id; 
 
		END 
  END

----------DELETE----------
CREATE PROCEDURE DeleteCourse (@Id INT) 
AS 
  BEGIN 
      DELETE Course
      WHERE  Id = @Id; 
  END

----------SELECT----------
CREATE PROCEDURE SelectCourse
AS 
  BEGIN 
		SELECT Id, Initials, Name, IsActive, Credits, Cycle
		FROM Course
END 

----------GetCourseById----------
CREATE PROCEDURE GetCourseById (@Id INT)
AS 
  BEGIN 
		SELECT Id, Initials, Name, IsActive, Credits, Cycle
		FROM Course
		WHERE Id = @Id
END 

---------------------------------------------------------
CREATE PROCEDURE InsertProfessorCourse (@ProfessorId INT,
									   @CourseId INT)

AS 
	BEGIN 
			INSERT INTO ProfessorCourse
						(ProfessorId,
						CourseId) 
			VALUES     (@ProfessorId,
						@CourseId); 
  END
---------------------------------------------------------
CREATE PROCEDURE InsertStudentCourse (@StudentId INT,
									   @CourseId INT)

AS 
	BEGIN 
			INSERT INTO StudentCourse
						(StudentId,
						CourseId) 
			VALUES     (@StudentId,
						@CourseId); 
  END

---------------------------------------------------------

CREATE PROCEDURE GetProfessorByIdCourse(@CourseId INT)

AS 
	BEGIN 
			SELECT P.Name, P.LastName, P.Id
			FROM Professor P, ProfessorCourse PC
			WHERE PC.CourseId = @CourseId
			AND PC.ProfessorId = P.Id
	END

---------------------------------------------------------

CREATE PROCEDURE GetStudentCourses (@StudentId INT)

AS 
	BEGIN 
			SELECT S.Id AS StudentId, C.Initials, C.Id AS CourseId, C.Name AS CourseName, C.Credits, C.Cycle, P.Id AS ProfessorId, P.Name AS ProfessorName, P.LastName AS ProfessorLastName
			FROM Student S, Course C, Professor P, StudentCourse SC, ProfessorCourse PC
			WHERE S.Id = @StudentId
			AND SC.StudentId = @StudentId
			AND SC.CourseId = C.Id
			AND SC.CourseId = PC.CourseId
			AND P.Id = PC.ProfessorId
  END

---------------------------------------------------------
CREATE PROCEDURE GetProfessorCourses (@ProfessorId INT)

AS 
	BEGIN 
			SELECT C.Initials, C.Name AS CourseName, C.Id AS CourseId, C.Cycle, C.Credits, 
			P.Id AS ProfessorId, P.Name AS ProfessorName, P.LastName AS ProfessorLastName
			FROM Course C, Professor P, ProfessorCourse PC
			WHERE C.Id = PC.CourseId
			AND P.Id = @ProfessorId
			AND PC.ProfessorId = @ProfessorId
  END
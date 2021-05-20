CREATE PROCEDURE InsertAppointment (@CourseId INT,
									@StudentId INT,
									@ProfessorId INT,
									@Motive VARCHAR(200),
									@Accepted INT,
									@DateTime VARCHAR(50))

AS 
	BEGIN 
		INSERT INTO Appointment 
						(CourseId,
						StudentId,
						ProfessorId,
						 Motive, 
						 Accepted,
						 DateTime) 
		VALUES     (@CourseId,
					@StudentId,
					@ProfessorId,
					@Motive,
					@Accepted,
					@DateTime); 

	END
---------------------------------------------------------
CREATE PROCEDURE StatusAppointment (@AppointmentId INT,
									@Accepted INT)

AS 
	BEGIN 
		UPDATE Appointment
		SET Accepted = @Accepted
		WHERE Id = @AppointmentId
	END
------------------------------------------------------
ALTER TABLE Appointment ADD ProfessorId INT
ALTER TABLE Appointment ADD FOREIGN KEY (ProfessorId) REFERENCES Professor(Id);

ALTER TABLE Appointment ALTER COLUMN DateTime varchar(50)
------------------------------------------------------
CREATE PROCEDURE GetAppointment (@StudentId INT, @ProfessorId INT, @CourseId INT)

AS 
	BEGIN 
		SELECT Id, CourseId, StudentId, DateTime, Motive, ProfessorId, Accepted
		FROM Appointment
		WHERE StudentId = @StudentId
		AND ProfessorId = @ProfessorId
		AND CourseId = @CourseId

	END

------------------------------------------------------
CREATE PROCEDURE GetAppointmentById (@Id INT)

AS 
	BEGIN 
		SELECT Id, CourseId, StudentId, DateTime, Motive, ProfessorId, Accepted
		FROM Appointment
		WHERE Id = @Id
	END

------------------------------------------------------
CREATE PROCEDURE GetAppointmentProfessor (@ProfessorId INT, @CourseId INT)

AS 
	BEGIN 
		SELECT Id, CourseId, StudentId, DateTime, Motive, ProfessorId, Accepted
		FROM Appointment
		WHERE ProfessorId = @ProfessorId
		AND CourseId = @CourseId

	END

------------------------------------------------------
CREATE PROCEDURE GetAppointmentProfessorByDate (@ProfessorId INT, @CourseId INT)

AS 

	BEGIN 
		SELECT Id, CourseId, StudentId, DateTime, Motive, ProfessorId, Accepted
		FROM Appointment
		WHERE ProfessorId = @ProfessorId
		AND CourseId = @CourseId
		AND DateTime = GETDATE() 

	END
CREATE PROCEDURE InsertPrivateMessage (@CourseId INT,
									@StudentId INT,
									@ProfessorId INT,
									@Motive VARCHAR(200),
									@DateTime VARCHAR(50))

AS 
	BEGIN 
		INSERT INTO PrivateMessage 
						(CourseId,
						StudentId,
						ProfessorId,
						 Motive,
						 DateTime) 
		VALUES     (@CourseId,
					@StudentId,
					@ProfessorId,
					@Motive,
					@DateTime); 

	END
----------------------------------------------------------------
CREATE PROCEDURE InsertPublicConsultation (@CourseId INT,
									@StudentId INT,
									@ProfessorId INT,
									@Motive VARCHAR(200),
									@DateTime VARCHAR(50))

AS 
	BEGIN 
		INSERT INTO PublicConsultation 
						(CourseId,
						StudentId,
						ProfessorId,
						 Motive,
						 DateTime) 
		VALUES     (@CourseId,
					@StudentId,
					@ProfessorId,
					@Motive,
					@DateTime); 

	END

----------------------------------------------------------------
CREATE PROCEDURE InsertRepliesPublicConsultation (@PublicConsultationId INT,
									@StudentId INT,
									@ProfessorId INT,
									@Motive VARCHAR(200),
									@DateTime VARCHAR(50))

AS 
	BEGIN 
		INSERT INTO RepliesPublicConsultation 
						(PublicConsultationId,
						StudentId,
						ProfessorId,
						 Motive,
						 DateTime) 
		VALUES     (@PublicConsultationId,
					@StudentId,
					@ProfessorId,
					@Motive,
					@DateTime); 

	END
----------------------------------------------------------------
CREATE PROCEDURE InsertRepliesPrivateMessage (@PrivateMessageId INT,
									@StudentId INT,
									@ProfessorId INT,
									@Motive VARCHAR(200),
									@DateTime VARCHAR(50))

AS 
	BEGIN 
		INSERT INTO RepliesPrivateMessage 
						(PrivateMessageId,
						StudentId,
						ProfessorId,
						 Motive,
						 DateTime) 
		VALUES     (@PrivateMessageId,
					@StudentId,
					@ProfessorId,
					@Motive,
					@DateTime); 

	END
-----------------------------------------------------------------
ALTER TABLE PublicConsultation ADD ProfessorId INT
ALTER TABLE PublicConsultation ADD FOREIGN KEY (ProfessorId) REFERENCES Professor(Id);

ALTER TABLE PrivateMessage ADD ProfessorId INT
ALTER TABLE PrivateMessage ADD FOREIGN KEY (ProfessorId) REFERENCES Professor(Id);
------------------------------------------------------------------
CREATE PROCEDURE GetPublicConsultation (@CourseId INT,
									@ProfessorId INT)

AS 
	BEGIN 
		SELECT Id, CourseId, StudentId, DateTime, Motive, ProfessorId
		FROM PublicConsultation
		WHERE CourseId = @CourseId
		AND ProfessorId = @ProfessorId

	END
------------------------------------------------------------------
CREATE PROCEDURE GetPrivateMessage (@CourseId INT,
									@ProfessorId INT)

AS 
	BEGIN 
		SELECT Id, CourseId, StudentId, DateTime, Motive, ProfessorId
		FROM PrivateMessage
		WHERE CourseId = @CourseId
		AND ProfessorId = @ProfessorId

	END
------------------------------------------------------------------
CREATE PROCEDURE GetRepliesPublicConsultation (@PublicConsultationId INT)

AS 
	BEGIN 
		SELECT Id, PublicConsultationId, StudentId, DateTime, Motive, ProfessorId
		FROM RepliesPublicConsultation
		WHERE PublicConsultationId = @PublicConsultationId

	END

------------------------------------------------------------------
CREATE PROCEDURE GetRepliesPrivateMessage (@PrivateMessageId INT)

AS 
	BEGIN 
		SELECT Id, PrivateMessageId, StudentId, DateTime, Motive, ProfessorId
		FROM RepliesPrivateMessage
		WHERE PrivateMessageId = @PrivateMessageId

	END
------------------------------------------------------------------
ALTER TABLE PublicConsultation ALTER COLUMN DateTime varchar(50)
ALTER TABLE RepliesPublicConsultation ALTER COLUMN DateTime varchar(50)
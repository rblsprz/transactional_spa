----------CRUD STUDENT----------
----------INSERT UPDATE----------
--Para IsAdministrator:
--0: No es Administrador
--1: Administrador

--Para Status
--Activo
--Inactivo

--Para RegistrationStatus
--En espera (Por defecto se pone en espera)
--Aceptado
--Rechazado
CREATE PROCEDURE InsertUpdateStudent (
									   @Id INT,
									   @Username VARCHAR(50),
									   @Password VARCHAR(50),
									   @IsAdministrator INT,
									   @Status VARCHAR(20),
									   @StudentCard VARCHAR(10), 
                                       @StudentName VARCHAR(50),
									   @LastName VARCHAR(50),
                                       @Birthday VARCHAR(50), 
									   @Mail VARCHAR(50),
									   @Image VARCHAR(200),
									   @RegistrationStatus VARCHAR(20),
									   @ProvinceId INT,
									   @CantonId INT,
									   @DistrictId INT,
                                       @Action VARCHAR(10))
AS DECLARE @LocationId INT;
	BEGIN 

      IF @Action = 'Insert' 
        BEGIN 
			INSERT INTO Users(Username,
							  Password,
							  IsAdministrator,
							  Status)
				VALUES	(@Username,
						@Password,
						@IsAdministrator,
						@Status)

			INSERT INTO Location (ProvinceId,
								  CantonId,
								  DistrictId)
						VALUES (@ProvinceId,
								@CantonId,
								@DistrictId);

			SELECT TOP 1 @LocationId = Id
			FROM Location ORDER BY Id DESC

			SELECT TOP 1 @Id = Id
			FROM Users ORDER BY Id DESC

            INSERT INTO Student 
                        (Id,
						StudentCard,
						StudentName, 
                         LastName, 
                         Birthday, 
                         Mail,
						 Image,
						 LocationId,
						 RegistrationStatus) 
            VALUES     (@Id,
						@StudentCard,
						@StudentName,
						@LastName,
                        @Birthday, 
                        @Mail,
						@Image,
						@LocationId,
						@RegistrationStatus); 

			
        END 
      IF @Action = 'Update' 
        BEGIN 
			SELECT @LocationId = LocationId
			FROM Student
			WHERE Id = @Id

			UPDATE Location
			SET ProvinceId = @ProvinceId,
				CantonId = @CantonId,
				DistrictId = @DistrictId
			WHERE Id = @LocationId

            UPDATE Student 
            SET    StudentName = @StudentName,
				   LastName = @LastName,
				   Mail = @Mail,
				   LocationId = @LocationId,
				   RegistrationStatus = @RegistrationStatus
            WHERE  Id = @Id; 

			UPDATE Users
            SET    Username = @Username,
				   Password = @Password,
				   IsAdministrator = @IsAdministrator,
				   Status = @Status
            WHERE  Id = @Id; 
        END 
  END

----------DELETE----------
CREATE PROCEDURE DeleteStudent (@Id INT) 
AS 
  BEGIN 
	  UPDATE Users
	  SET Status = 'Inactive'
	  WHERE  Id = @Id;
  END

----------SELECT----------
CREATE PROCEDURE SelectStudent
AS 
  BEGIN 
		SELECT S.Id, S.StudentCard, S.StudentName, S.LastName, S.Birthday, S.Mail, S.Image, S.RegistrationStatus, 
		P.Name AS Province, C.Name AS Canton, D.Name AS District, U.Username, U.Password, U.Status, U.IsAdministrator
		FROM Student S, Location L, Province P, Canton C, District D, Users U
		WHERE S.LocationId = L.Id
		AND L.ProvinceId = P.Id
		AND L.CantonId = C.Id
		AND L.DistrictId = D.Id
		AND S.Id = U.Id
END 

----------GetStudentById----------
CREATE PROCEDURE GetStudentById (@Id INT)
AS 
  BEGIN 
		SELECT S.Id, S.StudentCard, S.StudentName, S.LastName, S.Birthday, S.Mail, S.Image, S.RegistrationStatus, 
		P.Name AS Province, P.Id AS ProvinceId, C.Name AS Canton, C.Id AS CantonId, D.Name AS District, D.Id AS DistrictId,
		U.Username, U.Password, U.Status, U.IsAdministrator
		FROM Student S, Location L, Province P, Canton C, District D, Users U
		WHERE S.LocationId = L.Id
		AND L.ProvinceId = P.Id
		AND L.CantonId = C.Id
		AND L.DistrictId = D.Id
		AND S.Id = U.Id
		AND S.Id = @Id
END 

----------STUDENTAPPROVAL----------
CREATE PROCEDURE StudentApproval
AS 
  BEGIN 
		SELECT Id,StudentCard, StudentName, LastName, Mail
		FROM Student 
		WHERE RegistrationStatus = 'Waiting'
END 

----------UpdateStatusStudent----------
--LOS POSIBLES ESTADOS SON:
--En espera
--Aprobado
--Rechazado

CREATE PROCEDURE UpdateStatusStudent (@Id INT, @RegistrationStatus VARCHAR(20)) 
AS 
  BEGIN 

			UPDATE Student
			SET RegistrationStatus = @RegistrationStatus
			WHERE Id = @Id

  END

------------------------------
CREATE PROCEDURE ListStudent
AS 
  BEGIN 
		SELECT Id, StudentCard, StudentName
		FROM Student 
END 

------------------------------
CREATE PROCEDURE UpdateStudentImage (@Image VARCHAR(200), @Id INT) 
AS 
  BEGIN 

			UPDATE Student
			SET Image = @Image
			WHERE Id = @Id

  END
----------CRUD PROFESSOR----------
----------INSERT UPDATE----------
--Para IsAdministrator:
--0: No es Administrador
--1: Administrador

--Para Status
--Activo
--Inactivo

CREATE PROCEDURE InsertUpdateProfessor (
									   @Id INT,
									   @Username VARCHAR(50),
									   @Password VARCHAR(50),
									   @IsAdministrator INT,
									   @Status VARCHAR(20), 
                                       @Name VARCHAR(50),
									   @LastName VARCHAR(50), 
									   @Mail VARCHAR(50),
									   @Image VARCHAR(50),
									   @ProvinceId INT,
									   @CantonId INT,
									   @DistrictId INT,
									   @AcademicDegree INT,
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

            INSERT INTO Professor 
                        (Id,
						Name, 
                         LastName, 
                         Mail,
						 AcademicDegreeId,
						 Image,
						 LocationId) 
            VALUES     (@Id,
						@Name,
						@LastName,
                        @Mail,
						@AcademicDegree,
						@Image,
						@LocationId); 

			
        END 
      IF @Action = 'Update' 
        BEGIN 
			SELECT @LocationId = LocationId
			FROM Professor
			WHERE Id = @Id

			UPDATE Location
			SET ProvinceId = @ProvinceId,
				CantonId = @CantonId,
				DistrictId = @DistrictId
			WHERE Id = @LocationId

            UPDATE Professor 
            SET    Name = @Name,
				   LastName = @LastName,
				   Mail = @Mail,
				   AcademicDegreeId = @AcademicDegree,
				   LocationId = @LocationId
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
CREATE PROCEDURE DeleteProfessor (@Id INT) 
AS 
  BEGIN 

	  UPDATE Users
	  SET Status = 'Inactive'
	  WHERE  Id = @Id;
  END

----------SELECT----------
CREATE PROCEDURE SelectProfessor
AS 
  BEGIN 
		SELECT PR.Id, PR.Name, PR.LastName, PR.Mail, PR.Image, A.Name AS AcademicDegree, P.Name AS Province, C.Name AS Canton, D.Name AS District
		FROM Professor PR, Location L, Province P, Canton C, District D, AcademicDegree A
		WHERE PR.LocationId = L.Id
		AND L.ProvinceId = P.Id
		AND L.CantonId = C.Id
		AND L.DistrictId = D.Id
		AND PR.AcademicDegreeId = A.Id
END 

----------GetProfessorById----------
CREATE PROCEDURE GetProfessorById (@Id INT)
AS 
  BEGIN 
		SELECT PR.Id, PR.Name, PR.LastName, PR.Mail, PR.Image, A.Name AS AcademicDegree, A.Id AS AcademicDegreeId,
		P.Name AS Province, P.Id AS ProvinceId, C.Name AS Canton, C.Id AS CantonId, D.Name AS District, D.Id AS DistrictId,
		U.Username AS Username, U.Password AS Password, U.IsAdministrator AS IsAdministrator, U.Status AS Status
		FROM Professor PR, Location L, Province P, Canton C, District D, AcademicDegree A, Users U
		WHERE PR.LocationId = L.Id
		AND L.ProvinceId = P.Id
		AND L.CantonId = C.Id
		AND L.DistrictId = D.Id
		AND PR.AcademicDegreeId = A.Id
		AND U.Id = @Id
		AND PR.Id = @Id
END 

----------SELECT ACADEMICDEGREE----------
CREATE PROCEDURE SelectAcademicDegree
AS 
  BEGIN 
		SELECT Id, Name
		FROM AcademicDegree
END 

------------------------------------------
ALTER TABLE Professor ALTER COLUMN Image VARCHAR(200)
------------------------------------------
CREATE PROCEDURE UpdateProfessorImage (@Image VARCHAR(200), @Id INT) 
AS 
  BEGIN 

			UPDATE Professor
			SET Image = @Image
			WHERE Id = @Id

  END
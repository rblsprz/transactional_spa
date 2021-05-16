INSERT INTO SocialNetworksCatalog(Name)
VALUES ('Facebook')

INSERT INTO SocialNetworksCatalog(Name)
VALUES ('Twitter')

INSERT INTO SocialNetworksCatalog(Name)
VALUES ('LinkedIn')

INSERT INTO SocialNetworksCatalog(Name)
VALUES ('GitHub')

INSERT INTO SocialNetworksCatalog(Name)
VALUES ('Instagram')

INSERT INTO SocialNetworksCatalog(Name)
VALUES ('Stack Overflow')

select * from SocialNetworksCatalog

---------------------PROCEDIMIENTOS---------------------
CREATE PROCEDURE InsertUpdateSocialNetworkStudent (@Id INT,
										@StudentId INT,
									   @Url VARCHAR(50),
									   @SocialNetworksNameId INT,
									   @Action VARCHAR(10))

AS 
	BEGIN 
		IF @Action = 'Insert' 
			BEGIN 
			INSERT INTO SocialNetworksStudent 
						(StudentId,
						Url,
						SocialNetworksNameId) 
			VALUES     (@StudentId,
						@Url,
						@SocialNetworksNameId); 
		END 
		IF @Action = 'Update' 
		BEGIN 
			
			UPDATE SocialNetworksStudent 
			SET    Url = @Url,
			SocialNetworksNameId = @SocialNetworksNameId
			WHERE  StudentId = @StudentId
			AND Id = @Id;
 
		END 

  END
------------------------------------------------------------
CREATE PROCEDURE InsertUpdateSocialNetworkProfessor (@Id INT,
										@ProfessorId INT,
									   @Url VARCHAR(50),
									   @SocialNetworksNameId INT,
									   @Action VARCHAR(10))

AS 
	BEGIN 
		IF @Action = 'Insert' 
			BEGIN 
			INSERT INTO SocialNetworksProfessor 
						(ProfessorId,
						Url,
						SocialNetworksNameId) 
			VALUES     (@ProfessorId,
						@Url,
						@SocialNetworksNameId); 
		END 
		IF @Action = 'Update' 
		BEGIN 
			
			UPDATE SocialNetworksProfessor
			SET    Url = @Url,
			SocialNetworksNameId = @SocialNetworksNameId
			WHERE  Id = @Id
			AND ProfessorId = @ProfessorId;
 
		END 

  END
  ------------------------------------------------------------
CREATE PROCEDURE GetNameSocialNetworks

AS 
	BEGIN 
		SELECT Id, Name
		FROM SocialNetworksCatalog

	END

  ------------------------------------------------------------
CREATE PROCEDURE GetSocialNetworksByIdStudent(@Id INT)
AS 
	BEGIN 
		SELECT Id, Url, SocialNetworksNameId
		FROM SocialNetworksStudent
		WHERE StudentId = @Id

	END
------------------------------------------------------------
CREATE PROCEDURE GetSocialNetworksByIdProfessor(@Id INT)

AS 
	BEGIN 
		SELECT Id, Url, SocialNetworksNameId
		FROM SocialNetworksProfessor
		WHERE ProfessorId = @Id
	END
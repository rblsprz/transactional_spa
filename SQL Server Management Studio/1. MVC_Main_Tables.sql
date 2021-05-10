CREATE TABLE Province(
Id INT NOT NULL PRIMARY KEY,
Name VARCHAR(50) NOT NULL)

CREATE TABLE Canton(
Id INT NOT NULL PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
ProvinceId INT NOT NULL,
FOREIGN KEY (ProvinceId) REFERENCES Province(Id))

CREATE TABLE District(
Id INT NOT NULL PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
CantonId INT NOT NULL,
FOREIGN KEY (CantonId) REFERENCES Canton(Id))

CREATE TABLE Location(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
ProvinceId INT,
CantonId INT,
DistrictId INT,
FOREIGN KEY (ProvinceId) REFERENCES Province(Id),
FOREIGN KEY (CantonId) REFERENCES Canton(Id),
FOREIGN KEY (DistrictId) REFERENCES District(Id))

CREATE TABLE Users(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Username VARCHAR(50) NOT NULL,
Password VARCHAR(50) NOT NULL,
IsAdministrator INT NOT NULL,
Status VARCHAR(20))

CREATE TABLE Student(
Id INT NOT NULL PRIMARY KEY,
StudentCard VARCHAR(10) NOT NULL,
StudentName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
Birthday Date NOT NULL,
Mail VARCHAR(50),
Image VARCHAR(200),
LocationId INT,
RegistrationStatus VARCHAR(20),
FOREIGN KEY (LocationId) REFERENCES Location(Id),
FOREIGN KEY (Id) REFERENCES Users(Id))

CREATE TABLE SocialNetworksCatalog(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(100))

CREATE TABLE SocialNetworksStudent(
Id INT PRIMARY KEY IDENTITY(1,1),
StudentId INT,
Url VARCHAR(50) NOT NULL,
SocialNetworksNameId INT,
FOREIGN KEY (StudentId) REFERENCES Student(Id),
FOREIGN KEY (SocialNetworksNameId) REFERENCES SocialNetworksCatalog(Id))

CREATE TABLE AcademicDegree(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(50) NOT NULL)

CREATE TABLE Professor(
Id INT NOT NULL PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
Mail VARCHAR(50),
AcademicDegreeId INT,
Image VARCHAR(50),
LocationId int,
FOREIGN KEY (AcademicDegreeId) REFERENCES AcademicDegree(Id),
FOREIGN KEY (LocationId) REFERENCES Location(Id),
FOREIGN KEY (Id) REFERENCES Users(Id))

CREATE TABLE SocialNetworksProfessor(
Id INT PRIMARY KEY IDENTITY(1,1),
ProfessorId INT,
Url VARCHAR(50) NOT NULL,
SocialNetworksNameId INT,
FOREIGN KEY (ProfessorId) REFERENCES Professor(Id),
FOREIGN KEY (SocialNetworksNameId) REFERENCES SocialNetworksCatalog(Id))

CREATE TABLE Course(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Initials VARCHAR(10) NOT NULL,
Name VARCHAR(50) NOT NULL,
IsActive INT NOT NULL,
Credits INT NOT NULL,
Cycle INT NOT NULL)

CREATE TABLE StudentCourse(
StudentId INT,
CourseId INT,
FOREIGN KEY (StudentId) REFERENCES Student(Id),
FOREIGN KEY (CourseId) REFERENCES Course(Id),
PRIMARY KEY(StudentId, CourseId))

CREATE TABLE ProfessorCourse(
ProfessorId INT,
CourseId INT,
FOREIGN KEY (ProfessorId) REFERENCES Professor(Id),
FOREIGN KEY (CourseId) REFERENCES Course(Id),
PRIMARY KEY(ProfessorId, CourseId))

CREATE TABLE Appointment(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
CourseId INT,
StudentId INT,
Motive VARCHAR(200) NOT NULL,
Accepted INT NOT NULL,
DateTime DateTime,
FOREIGN KEY (StudentId) REFERENCES Student(Id),
FOREIGN KEY (CourseId) REFERENCES Course(Id))

CREATE TABLE PrivateMessage(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
CourseId INT,
StudentId INT,
DateTime DateTime,
Motive VARCHAR(200) NOT NULL,
FOREIGN KEY (StudentId) REFERENCES Student(Id),
FOREIGN KEY (CourseId) REFERENCES Course(Id))

CREATE TABLE PublicConsultation(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
CourseId INT,
StudentId INT,
DateTime DateTime,
Motive VARCHAR(200) NOT NULL,
FOREIGN KEY (StudentId) REFERENCES Student(Id),
FOREIGN KEY (CourseId) REFERENCES Course(Id))

CREATE TABLE RepliesPublicConsultation(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
PublicConsultationId INT,
StudentId INT NULL,
ProfessorId INT NULL,
DateTime DateTime,
Motive VARCHAR(200) NOT NULL,
FOREIGN KEY (PublicConsultationId) REFERENCES PublicConsultation(Id),
FOREIGN KEY (StudentId) REFERENCES Student(Id),
FOREIGN KEY (ProfessorId) REFERENCES Professor(Id))

CREATE TABLE RepliesPrivateMessage(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
PrivateMessageId INT,
StudentId INT NULL,
ProfessorId INT NULL,
DateTime DateTime,
Motive VARCHAR(200) NOT NULL,
FOREIGN KEY (PrivateMessageId) REFERENCES PrivateMessage(Id),
FOREIGN KEY (StudentId) REFERENCES Student(Id),
FOREIGN KEY (ProfessorId) REFERENCES Professor(Id))

------------------------------------------------------------
ALTER TABLE Student ALTER COLUMN Birthday varchar(50)
ALTER TABLE PrivateMessage ALTER COLUMN DateTime varchar(50)
ALTER TABLE RepliesPrivateMessage ALTER COLUMN DateTime varchar(50)
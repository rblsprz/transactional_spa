use [MVC_IF4101MVCLPAC]
select * from AcademicDegree
select * from Appointment
select * from Canton
select * from Course
select * from District
select * from Location
select * from PrivateMessage
select * from Professor
select * from ProfessorCourse
select * from Province
select * from PublicConsultation
select * from RepliesPrivateMessage
select * from RepliesPublicConsultation
select * from SocialNetworksCatalog
select * from SocialNetworksStudent
select * from Student
select * from StudentCourse
select * from Users

Scaffold-DbContext "Server=163.178.107.10;Initial Catalog=MVC_IF4101MVCLPAC;User ID=laboratorios;Password=KmZpo.2796" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/Entities -Tables AcademicDegree,Appointment,Canton,Course,District,Location,PrivateMessage,Professor,ProfessorCourse,Province,PublicConsultation,RepliesPrivateMessage,RepliesPublicConsultation,SocialNetworksCatalog,SocialNetworksStudent,Student,StudentCourse,Users
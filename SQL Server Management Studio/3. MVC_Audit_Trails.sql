
--TABLA PROFESSORCOURSE--
ALTER TABLE PROFESSORCOURSE ADD CreatedBy INT FOREIGN KEY (CreatedBy) REFERENCES Users(Id)
ALTER TABLE PROFESSORCOURSE ADD CreateAt DATE 
ALTER TABLE PROFESSORCOURSE ADD UpdatedBy  INT FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
ALTER TABLE PROFESSORCOURSE ADD UpdatedAt DATE

--TABLA PROVINCE--
ALTER TABLE PROVINCE ADD CreatedBy INT FOREIGN KEY (CreatedBy) REFERENCES Users(Id)
ALTER TABLE PROVINCE ADD CreateAt DATE 
ALTER TABLE PROVINCE ADD UpdatedBy  INT FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
ALTER TABLE PROVINCE ADD UpdatedAt DATE

--TABLA PUBLICCONSULTATION--
ALTER TABLE PUBLICCONSULTATION ADD CreatedBy INT FOREIGN KEY (CreatedBy) REFERENCES Users(Id)
ALTER TABLE PUBLICCONSULTATION ADD CreateAt DATE 
ALTER TABLE PUBLICCONSULTATION ADD UpdatedBy  INT FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
ALTER TABLE PUBLICCONSULTATION ADD UpdatedAt DATE

--TABLA SOCIALNETWORKSPROFESSOR--
ALTER TABLE SOCIALNETWORKSPROFESSOR ADD CreatedBy INT FOREIGN KEY (CreatedBy) REFERENCES Users(Id)
ALTER TABLE SOCIALNETWORKSPROFESSOR ADD CreateAt DATE 
ALTER TABLE SOCIALNETWORKSPROFESSOR ADD UpdatedBy  INT FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
ALTER TABLE SOCIALNETWORKSPROFESSOR ADD UpdatedAt DATE

--TABLA SOCIALNETWORKSSTUDENT--
ALTER TABLE SOCIALNETWORKSSTUDENT ADD CreatedBy INT FOREIGN KEY (CreatedBy) REFERENCES Users(Id)
ALTER TABLE SOCIALNETWORKSSTUDENT ADD CreateAt DATE 
ALTER TABLE SOCIALNETWORKSSTUDENT ADD UpdatedBy  INT FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
ALTER TABLE SOCIALNETWORKSSTUDENT ADD UpdatedAt DATE

--TABLA STUDENT--
ALTER TABLE STUDENT ADD CreatedBy INT FOREIGN KEY (CreatedBy) REFERENCES Users(Id)
ALTER TABLE STUDENT ADD CreateAt DATE 
ALTER TABLE STUDENT ADD UpdatedBy  INT FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
ALTER TABLE STUDENT ADD UpdatedAt DATE

--TABLA STUDENTCOURSE--
ALTER TABLE STUDENTCOURSE ADD CreatedBy INT FOREIGN KEY (CreatedBy) REFERENCES Users(Id)
ALTER TABLE STUDENTCOURSE ADD CreateAt DATE 
ALTER TABLE STUDENTCOURSE ADD UpdatedBy  INT FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
ALTER TABLE STUDENTCOURSE ADD UpdatedAt DATE
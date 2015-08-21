CREATE TABLE dbo.tblStudentParents
(
	StudentParentId		INT IDENTITY(1, 1)
	, StudentId			INT NOT NULL
	, ParentId			INT NOT NULL
	, CONSTRAINT pk_student_parent_id PRIMARY KEY (StudentParentId)
	, CONSTRAINT fk_tblstudentparents_student_id FOREIGN KEY (StudentId) REFERENCES tblStudents (StudentId)
	, CONSTRAINT fk_tblstudentparents_parent_id FOREIGN KEY (ParentId) REFERENCES tblParents (ParentId)
)
GO
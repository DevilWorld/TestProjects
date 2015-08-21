CREATE TABLE dbo.tblStudentClasses
(	
	StudentClassId		INT IDENTITY(1, 1)
	, StudentId			INT	NOT NULL
	, ClassId			INT	NOT NULL
	, FromDate			DATETIME	NOT NULL
	, ToDate			DATETIME	NOT NULL
	, CONSTRAINT pk_student_class_id	PRIMARY KEY	(StudentClassId)
	, CONSTRAINT fk_tblstudentclasses_student_id	FOREIGN KEY (StudentId) REFERENCES tblStudents (StudentId)
	, CONSTRAINT fk_tblstudentclasses_class_id	FOREIGN KEY (ClassId) REFERENCES tblClass (ClassId)
)
GO
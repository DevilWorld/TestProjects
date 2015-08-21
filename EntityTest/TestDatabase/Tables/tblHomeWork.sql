CREATE TABLE dbo.tblHomeWork
(
	HomeWorkId		INT IDENTITY(1, 1)
	, StudentId		INT	NOT NULL
	, ClassId		INT	NOT NULL
	, HomeWorkContent	VARCHAR(500)	NOT NULL
	, CreatedBy			INT		NOT NULL
	, DateCreated		DATETIME	NOT NULL
	, CompletedOn		DATETIME	NULL
	, CONSTRAINT pk_tblHomeWork_home_work_id	PRIMARY KEY (HomeWorkId)
	, CONSTRAINT fk_tblhomework_student_id	FOREIGN KEY	(StudentId)	REFERENCES tblStudents (StudentId)
	, CONSTRAINT fk_tblhomework_class_id	FOREIGN KEY	(ClassId)	REFERENCES tblClass (ClassId)
)
GO
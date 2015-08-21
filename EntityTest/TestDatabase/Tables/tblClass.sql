CREATE TABLE dbo.tblClass
(
	ClassId		INT IDENTITY(1, 1)
	, ClassName		VARCHAR(50)		NOT NULL
	, TeacherId		INT			NOT NULL
	, SubjectId		INT NOT NULL
	, TeacherFromDate		DATETIME
	, TeacherToDate		DATETIME
	, CONSTRAINT pk_class_id	PRIMARY KEY (ClassId)
	, CONSTRAINT fk_tblclass_teacher_id		FOREIGN KEY	(TeacherId) REFERENCES	tblTeacher (TeacherId)
	, CONSTRAINT fk_tblclass_subject_id		FOREIGN KEY	(SubjectId) REFERENCES	tblSubjects (SubjectId)
)
GO
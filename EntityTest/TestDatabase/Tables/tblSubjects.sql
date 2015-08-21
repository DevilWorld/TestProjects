CREATE TABLE dbo.tblSubjects
(
	SubjectId	INT IDENTITY(1, 1)
	, SubjectName		VARCHAR(100)	NOT NULL
	CONSTRAINT pk_subject_id	PRIMARY KEY (SubjectId)
)
GO
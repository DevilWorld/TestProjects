CREATE TABLE dbo.tblStudents
(
	StudentId		INT IDENTITY(1, 1)
	, FirstName		VARCHAR(30)
	, MiddleName	VARCHAR(30)
	, LastName		VARCHAR(30)
	, Gender		VARCHAR(1)
	, DOB			DATETIME	
	, CONSTRAINT pk_studuent_id PRIMARY KEY (StudentId)
)
GO
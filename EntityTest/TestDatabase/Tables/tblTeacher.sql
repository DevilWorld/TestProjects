CREATE TABLE dbo.tblTeacher
(
	TeacherId	INT IDENTITY(1, 1)
	, FirstName		VARCHAR(100)	NOT NULL
	, MiddleName	VARCHAR(50)		NULL
	, LastName		VARCHAR(100)	NOT NULL
	, Gender		VARCHAR(1)		NOT NULL
	, DOB			DATETIME		NOT NULL
	, SchoolId		INT				NOT NULL
	, AddressId		INT				NOT NULL
	, CONSTRAINT pk_tblteacher_teacher_id	PRIMARY KEY (TeacherId)
	, CONSTRAINT fk_tblteacher_school_id	FOREIGN KEY	(SchoolId) REFERENCES tblSchool (SchoolId)
	, CONSTRAINT fk_tblteacher_address_id	FOREIGN KEY	(AddressId) REFERENCES tblAddress (AddressId)
)
GO
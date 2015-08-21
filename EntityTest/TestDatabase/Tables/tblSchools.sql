CREATE TABLE dbo.tblSchools
(
	SchoolId	INT IDENTITY(1, 1)
	, SchoolName	VARCHAR(100)	NOT NULL
	, SchoolAddressId	INT		NOT NULL
	, PrincipalId		INT NOT NULL
)
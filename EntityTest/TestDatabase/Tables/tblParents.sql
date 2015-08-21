CREATE TABLE dbo.tblParents
(
	ParentId	INT IDENTITY(1, 1)
	, FirstName	VARCHAR(100)		NOT NULL
	, MiddleName	VARCHAR(30)		NOT NULL
	, LastName		VARCHAR(100)		NOT NULL
	, Gender		VARCHAR(1)			NOT NULL
	, DOB			DATETIME			NOT NULL
	, CONSTRAINT	pk_parent_id	PRIMARY KEY (ParentId)
)
GO
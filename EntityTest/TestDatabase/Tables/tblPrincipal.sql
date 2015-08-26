CREATE TABLE dbo.tblPrincipal
(
	PrincipalId		INT IDENTITY(1, 1)
	, FirstName		VARCHAR(100)	NOT NULL
	, MiddleName	VARCHAR(50)		NULL
	, LastName		VARCHAR(100)	NOT NULL
	, Gender		VARCHAR(1)		NOT NULL
	, DOB			DATETIME		NOT NULL
	, AddressId		INT				NULL
	, CONSTRAINT pk_tblprincipal_principal_id PRIMARY KEY (PrincipalId)
	, CONSTRAINT fk_tblprincipal_address_id	FOREIGN KEY (AddressId) REFERENCES tblAddress(AddressId)
)
GO

ALTER TABLE dbo.tblPrincipal DROP CONSTRAINT fk_tblprincipal_address_id
GO
ALTER TABLE dbo.tblPrincipal DROP COLUMN AddressId
GO
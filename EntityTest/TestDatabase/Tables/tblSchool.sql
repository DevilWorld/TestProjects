CREATE TABLE dbo.tblSchool
(
	SchoolId	INT	IDENTITY(1, 1)
	, SchoolName	VARCHAR(250)	NOT NULL
	, SchoolAddressId	INT			NOT NULL
	, PrincipalId	INT				NOT NULL
	, CONSTRAINT pk_tblschool_school_id		PRIMARY KEY	(SchoolId)
	, CONSTRAINT fk_tblschool_school_address_id	FOREIGN KEY (SchoolAddressId) REFERENCES tblAddress (AddressId)
	, CONSTRAINT fk_tblschool_principal_id	FOREIGN KEY (PrincipalId) REFERENCES tblPrincipal (PrincipalId)
)
GO

ALTER TABLE dbo.tblSchool DROP CONSTRAINT fk_tblschool_school_address_id
GO

ALTER TABLE dbo.tblSchool DROP COLUMN SchoolAddressId
GO

ALTER TABLE dbo.tblSchool ADD Address1	VARCHAR(100)	NULL
								, Address2	VARCHAR(100)	NULL
								, City		VARCHAR(30)		NULL
								, [State]	VARCHAR(30)		NULL
								, Zip		INT				NULL
GO


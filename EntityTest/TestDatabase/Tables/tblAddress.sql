CREATE TABLE dbo.tblAddress
(
	AddressId	INT	IDENTITY(1, 1)
	, Address1	VARCHAR(100)
	, Address2	VARCHAR(100)
	, City		VARCHAR(30)
	, [State]	VARCHAR(30)
	, Zip		INT
	CONSTRAINT pk_address_id	PRIMARY KEY	(AddressId)
)
GO
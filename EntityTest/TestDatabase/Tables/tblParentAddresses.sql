CREATE TABLE dbo.tblParentAddresses
(
	ParentAddressId		INT		IDENTITY(1, 1)
	, ParentId			INT		NOT NULL
	, AddressId			INT		NOT NULL
	, FromDate			DATETIME
	, ToDate			DATETIME
	, CONSTRAINT pk_parent_address_id PRIMARY KEY (ParentAddressId)
	, CONSTRAINT fk_parent_id FOREIGN KEY (ParentId) REFERENCES tblParents (ParentId)
	, CONSTRAINT fk_address_id FOREIGN KEY (AddressId) REFERENCES tblAddress (AddressId)
)
GO
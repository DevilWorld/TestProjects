CREATE TABLE dbo.tblPricipalAddress
(
	PrincipalId		INT
	, Address1		VARCHAR(100)
	, Address2		VARCHAR(100)
	, City			VARCHAR(50)
	, [State]		VARCHAR(50)
	, Zip			INT
	, CONSTRAINT pk_tblpricipaladdress_principal_id PRIMARY KEY (PrincipalId)	
)
GO
CREATE TABLE dbo.tblStudentAddresses
(
	StudentAddressId	INT	IDENTITY(1, 1)
	, StudentId			INT
	, AddressId			INT
	, FromDate			DATETIME	NULL
	, ToDate			DATETIME	NULL
	, CONSTRAINT pk_student_address_id	PRIMARY KEY	(StudentAddressId)
	, CONSTRAINT fk_student_id FOREIGN KEY (StudentId) REFERENCES tblStudents (StudentId)
)
GO
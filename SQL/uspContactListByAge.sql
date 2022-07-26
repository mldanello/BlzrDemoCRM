DROP PROCEDURE IF EXISTS uspContactsByAge;
GO

Create Procedure uspContactsByAge
AS

WITH CTE_Contact(Name, Age)
AS
(
	Select CONCAT(Isnull(FirstName, ''), ISNULL(MiddleName, ''), IsNull(LastName, '')), Age
	From Contact
)

select *
FROM CTE_Contact
order by Age DESC
CREATE PROCEDURE [dbo].[spCustomer_Read_SearchBar]
	@SearchTerm NVARCHAR(20)
AS
BEGIN

	SELECT TOP 3 [ID], [FirstName], [LastName], [Email], [PhoneNumber], [Address] FROM dbo.Customer
	WHERE FirstName LIKE  '%' + @SearchTerm + '%'
	OR LastName LIKE '%' + @SearchTerm + '%';

END
RETURN 0

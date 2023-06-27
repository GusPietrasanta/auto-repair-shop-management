CREATE PROCEDURE [dbo].[spCustomer_ReadAll]
AS
BEGIN

	SELECT [ID], [FirstName], [LastName], [Email], [PhoneNumber], [Address] FROM dbo.Customer;

END
RETURN 0

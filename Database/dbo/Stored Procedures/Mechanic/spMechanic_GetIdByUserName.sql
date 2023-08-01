CREATE PROCEDURE [dbo].[spMechanic_GetIdByUserName]
	@FirstName NVARCHAR(50)
AS
BEGIN
	SELECT Id FROM dbo.Mechanic WHERE FirstName = @FirstName;
END
RETURN 0

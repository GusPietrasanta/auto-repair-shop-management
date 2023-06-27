CREATE PROCEDURE [dbo].[spCustomer_Create]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Email NVARCHAR(100),
	@PhoneNumber NVARCHAR(30),
	@Address NVARCHAR(250)
AS
BEGIN

	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM dbo.Customer WHERE FirstName = @FirstName AND LastName = @LastName)
	BEGIN
		INSERT INTO dbo.Customer (FirstName, LastName, Email, PhoneNumber, Address) 
		VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Address);
	END

	SELECT TOP 1 [ID] FROM dbo.Customer WHERE FirstName = @FirstName AND @LastName = @LastName;

END

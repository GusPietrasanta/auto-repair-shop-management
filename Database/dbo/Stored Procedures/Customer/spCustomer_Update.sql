CREATE PROCEDURE [dbo].[spCustomer_Update]
	@ID INT,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Email NVARCHAR(100),
	@PhoneNumber NVARCHAR(30),
	@Address NVARCHAR(250)
AS

	UPDATE dbo.Customer SET 
	FirstName = @FirstName,
	LastName = @LastName,
	Email = @Email,
	PhoneNumber = @PhoneNumber,
	[Address] = @Address
	WHERE ID = @ID;

RETURN 0

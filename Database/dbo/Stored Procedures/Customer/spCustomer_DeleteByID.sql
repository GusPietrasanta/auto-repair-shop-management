CREATE PROCEDURE [dbo].[spCustomer_DeleteByID]
	@ID INT
AS

	DELETE FROM dbo.Customer WHERE ID = @ID;

RETURN 0

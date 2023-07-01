CREATE PROCEDURE [dbo].[spCustomer_Read_By_ID]
	@ID INT
AS
	SELECT * FROM dbo.Customer WHERE ID = @ID;
RETURN 0

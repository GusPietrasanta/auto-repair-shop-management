CREATE PROCEDURE [dbo].[spVehicle_UpdateFirstVisitByID]
	@FirstVisit DATETIME2,
	@ID INT
AS

BEGIN
	UPDATE dbo.Vehicle SET FirstVisit = @FirstVisit WHERE ID = @ID;
END

RETURN 0

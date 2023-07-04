CREATE PROCEDURE [dbo].[spReport_Read_By_VehicleID]
	@VehicleID INT

AS
BEGIN

	SELECT * FROM dbo.Report WHERE VehicleID = @VehicleID
	ORDER BY TimeStarted DESC;

END
RETURN 0

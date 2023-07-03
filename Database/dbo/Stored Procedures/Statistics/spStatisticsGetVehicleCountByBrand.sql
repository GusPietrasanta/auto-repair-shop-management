CREATE PROCEDURE [dbo].[spStatisticsGetVehicleCountByBrand]

AS
BEGIN

	SELECT Make, COUNT(*) AS VehicleCount FROM dbo.Vehicle WHERE Make IS NOT NULL GROUP BY Make;

END
RETURN 0

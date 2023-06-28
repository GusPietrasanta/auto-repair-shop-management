CREATE PROCEDURE [dbo].[spVehicle_ReadByID]
	@ID int
AS

BEGIN
	
	SELECT [ID], [CustomerID], [NumberPlate], [Make], [Model], [Year], [VIN], [FuelType], [TransmissionType], [EngineDescription], [BodyType], [Cylinders], [SizeLitres], [FirstVisit] FROM dbo.Vehicle WHERE ID = @ID;

END
RETURN 0

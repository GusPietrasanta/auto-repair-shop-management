CREATE PROCEDURE [dbo].[spVehicle_ReadAll]
AS
	SELECT [ID], [CustomerID], [NumberPlate], [Make], [Model], [Year], [VIN], [FuelType], [TransmissionType], [EngineDescription], [BodyType], [Cylinders], [SizeLitres], [FirstVisit] 
	FROM dbo.Vehicle;
RETURN 0

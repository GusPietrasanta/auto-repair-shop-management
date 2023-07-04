CREATE PROCEDURE [dbo].[spVehicle_ReadByCustomerID]
	@CustomerID INT
AS

BEGIN
	SELECT [ID], [CustomerID], [NumberPlate], [Make], [Model], [Year], [VIN], [FuelType], [TransmissionType], [EngineDescription], [BodyType], [Cylinders], [SizeLitres], [FirstVisit] FROM dbo.Vehicle WHERE CustomerID = @CustomerID;
END

RETURN 0

CREATE PROCEDURE [dbo].[spVehicle_Read_SearchBar]
	@SearchTerm NVARCHAR(20)
AS

BEGIN
	SELECT TOP 3 [ID], [CustomerID], [NumberPlate], [Make], [Model], [Year], [VIN], [FuelType], [TransmissionType], [EngineDescription], [BodyType], [Cylinders], [SizeLitres], [FirstVisit] 
	FROM dbo.Vehicle 
	WHERE Make LIKE '%' + @SearchTerm + '%'
	OR Model LIKE '%' + @SearchTerm + '%'
	OR NumberPlate LIKE '%' + @SearchTerm + '%';
END

RETURN 0

CREATE PROCEDURE [dbo].[spVehicle_Create]
	@CustomerID int,
	@NumberPlate NVARCHAR(10),
	@Make NVARCHAR(50),
	@Model NVARCHAR(50),
	@Year CHAR(4),
	@VIN CHAR(17),
	@FuelType VARCHAR(10),
	@TransmissionType VARCHAR(10),
	@EngineDescription NVARCHAR(50),
	@BodyType VARCHAR(50),
	@Cylinders VARCHAR(6),
	@SizeLitres DECIMAL(4,2)

AS
BEGIN
	
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM dbo.Vehicle WHERE VIN = @VIN)

	BEGIN
		INSERT INTO dbo.Vehicle (CustomerID, NumberPlate, Make, Model, Year, VIN, FuelType, 
		TransmissionType, EngineDescription, BodyType, Cylinders, SizeLitres)
		VALUES (@CustomerID, @NumberPlate, @Make, @Model, @Year, @VIN, @FuelType, 
		@TransmissionType, @EngineDescription, @BodyType, @Cylinders, @SizeLitres);
	END

	SELECT TOP 1 [ID] FROM dbo.Vehicle WHERE VIN = @VIN;

END

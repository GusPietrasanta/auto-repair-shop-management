CREATE PROCEDURE [dbo].[spVehicle_Update]
	@ID INT,
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
	@SizeLitres DECIMAL(4,2),
	@FirstVisit DATETIME2

AS
BEGIN
	
	SET NOCOUNT ON;

	BEGIN
		UPDATE dbo.Vehicle SET 
		NumberPlate = @NumberPlate, 
		Make = @Make, 
		Model = @Model, 
		Year = @Year, 
		VIN = @VIN, 
		FuelType = @FuelType, 
		TransmissionType = @TransmissionType, 
		EngineDescription = @EngineDescription, 
		BodyType = @BodyType, 
		Cylinders = @Cylinders, 
		SizeLitres = @SizeLitres,
		FirstVisit = @FirstVisit
		WHERE ID = @ID;
	END

END

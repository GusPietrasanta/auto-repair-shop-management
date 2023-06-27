CREATE PROCEDURE [dbo].[spAppointment_Create]
	@CustomerID INT,
	@VehicleID INT,
	@Date DATETIME2
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Appointment (CustomerID, VehicleID, Date)
	VALUES (@CustomerID, @VehicleID, @Date)

	SELECT TOP 1 [ID] FROM dbo.Appointment WHERE CustomerID = @CustomerID AND VehicleID = @VehicleID AND Date = @Date;

END

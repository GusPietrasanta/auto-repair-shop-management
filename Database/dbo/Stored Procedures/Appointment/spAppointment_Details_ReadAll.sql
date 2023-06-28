CREATE PROCEDURE [dbo].[spAppointment_Details_ReadAll]

AS
BEGIN

	SET NOCOUNT ON;
	
	SELECT a.ID, a.Date, a.MechanicID, c.FirstName, c.LastName, v.NumberPlate, v.Make, v.Model
	FROM dbo.Appointment a
	INNER JOIN dbo.Vehicle v ON  a.VehicleID = v.ID
	INNER JOIN dbo.Customer c ON  a.CustomerID = c.ID
	ORDER BY a.Date;

END

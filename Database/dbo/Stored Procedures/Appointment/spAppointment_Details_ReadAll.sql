CREATE PROCEDURE [dbo].[spAppointment_Details_ReadAll]

AS
BEGIN

	SET NOCOUNT ON;
	
	SELECT a.ID, a.MechanicID, a.CustomerID, a.Date, c.FirstName, c.LastName, v.NumberPlate, v.Make, v.Model, m.UserName
	FROM dbo.Appointment a
	INNER JOIN dbo.Vehicle v ON  a.VehicleID = v.ID
	INNER JOIN dbo.Customer c ON  a.CustomerID = c.ID
	LEFT JOIN dbo.Mechanic m ON a.MechanicID = m.ID
	ORDER BY a.Date;

END

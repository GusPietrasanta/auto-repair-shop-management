CREATE PROCEDURE [dbo].[spAppointment_Today_Details]
	@Today DATETIME2
AS

BEGIN

	SET NOCOUNT ON;
	
	SELECT a.ID, a.MechanicID, a.Completed, a.CustomerID, a.Date, c.FirstName, c.LastName, v.NumberPlate, v.Make, v.Model, m.UserName
	FROM dbo.Appointment a
	INNER JOIN dbo.Vehicle v ON  a.VehicleID = v.ID
	INNER JOIN dbo.Customer c ON  a.CustomerID = c.ID
	LEFT JOIN dbo.Mechanic m ON a.MechanicID = m.ID
	WHERE CAST(a.Date AS DATE) = @Today
	ORDER BY a.Date;

END


RETURN 0

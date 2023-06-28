CREATE PROCEDURE [dbo].[spAppointment_ReadAll]
AS
	SELECT [ID], [CustomerID], [VehicleID], [Date], [MechanicID], [Completed] FROM dbo.Appointment;
RETURN 0

CREATE PROCEDURE [dbo].[spAppointment_AssignMechanicByID]
	@MechanicID int,
	@AppointmentID int
AS

BEGIN

	UPDATE dbo.Appointment SET MechanicID = @MechanicID WHERE ID = @AppointmentID;

END


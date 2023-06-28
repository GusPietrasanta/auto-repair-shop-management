CREATE PROCEDURE [dbo].[spAppointment_UpdateCompletedById]
	@ID int
AS

BEGIN

	UPDATE dbo.Appointment SET Completed = 1 WHERE ID = @ID;

END

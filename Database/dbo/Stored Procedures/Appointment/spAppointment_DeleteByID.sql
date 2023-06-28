CREATE PROCEDURE [dbo].[spAppointment_DeleteByID]
	@ID int
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM dbo.Appointment WHERE ID = @ID;

END

RETURN 0

CREATE PROCEDURE [dbo].[spAppointment_CountByMechanicToday]
	@UserName NVARCHAR(50),
	@Date DATETIME2
AS
BEGIN

	SELECT COUNT(*)
	FROM dbo.Appointment 
	WHERE CAST(Date AS DATE) = @Date 
	AND MechanicID = (SELECT ID FROM dbo.Mechanic WHERE UserName = @UserName)
	AND Completed = 0;

END

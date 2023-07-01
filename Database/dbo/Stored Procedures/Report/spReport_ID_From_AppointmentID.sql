CREATE PROCEDURE [dbo].[spReport_ID_From_AppointmentID]
	@AppointmentID INT
AS
BEGIN
	SELECT ID FROM dbo.Report WHERE AppointmentID = @AppointmentID;
END

CREATE PROCEDURE [dbo].[spReport_Archive]
	@ID INT
AS
	UPDATE dbo.Report SET Archived = 1 WHERE ID = @ID;
RETURN 0

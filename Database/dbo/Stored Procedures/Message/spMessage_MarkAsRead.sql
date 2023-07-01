CREATE PROCEDURE [dbo].[spMessage_MarkAsRead]
	@ID INT
AS
	UPDATE dbo.Message SET [Read] = 1 WHERE ID = @ID;
RETURN 0

CREATE PROCEDURE [dbo].[spMessage_ReadAll]
AS
BEGIN
	SELECT [ID], [UserName], [Content], [PostedOn], [Read], [Tag] FROM dbo.Message
	WHERE [Read] = 0
	ORDER BY [PostedOn] DESC;
END

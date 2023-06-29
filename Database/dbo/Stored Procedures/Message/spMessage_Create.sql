CREATE PROCEDURE [dbo].[spMessage_Create]
	@UserName NVARCHAR(50),
	@Content VARCHAR(MAX),
	@PostedOn DATETIME2,
	@Tag VARCHAR(20)
AS
BEGIN

	INSERT INTO dbo.Message(UserName, Content, PostedOn, Tag)
	VALUES(@UserName, @Content, @PostedOn, @Tag);

END


CREATE PROCEDURE [dbo].[spStock_Create]
	@ItemName NVARCHAR(100),
	@Quantity DECIMAL(5, 2),
	@Unit VARCHAR(15),
	@AlarmMinimum DECIMAL(5, 2)
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.Stock (ItemName, Quantity, Unit, AlarmMinimum) 
	VALUES (@ItemName, @Quantity, @Unit, @AlarmMinimum);

END
CREATE PROCEDURE [dbo].[spStock_Update_ByID]
	@ID INT,
	@ItemName NVARCHAR(100),
	@Quantity DECIMAL(5, 2),
	@Unit VARCHAR(15),
	@AlarmMinimum DECIMAL(5, 2)
AS
BEGIN

	UPDATE dbo.Stock 
	SET 
	ItemName = @ItemName,
	Quantity = @Quantity,
	Unit = @Unit,
	AlarmMinimum = @AlarmMinimum
	WHERE ID = @ID;

END
RETURN 0

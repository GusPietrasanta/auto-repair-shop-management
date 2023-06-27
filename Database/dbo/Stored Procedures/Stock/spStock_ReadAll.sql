CREATE PROCEDURE [dbo].[spStock_ReadAll]
AS
BEGIN 

	SELECT [ID], [ItemName], [Quantity], [Unit], [AlarmMinimum] FROM dbo.Stock;

END

RETURN 0
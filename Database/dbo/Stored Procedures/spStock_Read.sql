CREATE PROCEDURE [dbo].[spStock_Read]
AS
BEGIN 

	SELECT [ID], [ItemName], [Quantity], [Unit], [AlarmMinimum] FROM dbo.Stock;

END

CREATE PROCEDURE [dbo].[spStock_ReadLows]
AS

BEGIN
	SELECT [ID], [ItemName], [Quantity], [Unit], [AlarmMinimum] FROM dbo.Stock WHERE (Quantity <= AlarmMinimum);
END

RETURN 0

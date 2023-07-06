CREATE PROCEDURE [dbo].[spStock_Read_SearchBar]
	@SearchTerm NVARCHAR(20)

AS
BEGIN

	SELECT TOP 3 [ID], [ItemName], [Quantity], [Unit], [AlarmMinimum] FROM dbo.Stock WHERE ItemName LIKE '%' + @SearchTerm + '%';

END
RETURN 0

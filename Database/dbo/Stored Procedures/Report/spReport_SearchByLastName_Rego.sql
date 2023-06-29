CREATE PROCEDURE [dbo].[spReport_SearchByLastName_Rego]
	@LastName NVARCHAR(50),
	@NumberPlate NVARCHAR(10)
AS
BEGIN

		SELECT * FROM dbo.Report 
		WHERE CustomerID = (SELECT ID FROM dbo.Customer WHERE LastName = @LastName) 
		AND VehicleID = (SELECT ID FROM dbo.Vehicle WHERE NumberPlate = @NumberPlate)
		ORDER BY TimeStarted DESC;
END

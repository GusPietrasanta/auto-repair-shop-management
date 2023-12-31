﻿CREATE PROCEDURE [dbo].[spReport_SearchAllDashboardNonArchived]

AS
BEGIN
	SELECT r.ID, r.TimeFinished, c.FirstName, c.LastName, v.NumberPlate, m.UserName, v.Make, v.Model, v.Year
	FROM dbo.Report r
	INNER JOIN dbo.Mechanic m ON r.MechanicID = m.ID
	INNER JOIN dbo.Customer c on r.CustomerID = c.ID
	INNER JOIN dbo.Vehicle v on r.VehicleID = v.ID
	ORDER BY r.TimeFinished DESC;
END
RETURN 0

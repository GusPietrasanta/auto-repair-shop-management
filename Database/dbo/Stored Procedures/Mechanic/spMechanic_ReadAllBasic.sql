CREATE PROCEDURE [dbo].[spMechanic_ReadAllBasic]
AS

	SELECT [ID], [UserName] FROM dbo.Mechanic;

RETURN 0

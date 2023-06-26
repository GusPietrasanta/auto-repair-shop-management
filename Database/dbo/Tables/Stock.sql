CREATE TABLE [dbo].[Stock]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [ItemName] NVARCHAR(100) NOT NULL, 
    [Quantity] DECIMAL(5, 2) NOT NULL, 
    [Unit] VARCHAR(15) NOT NULL, 
    [AlarmMinimum] DECIMAL(5, 2) NOT NULL
)

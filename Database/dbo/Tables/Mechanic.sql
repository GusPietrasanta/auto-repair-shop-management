﻿CREATE TABLE [dbo].[Mechanic]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Joined] DATETIME2 NOT NULL, 
    [DateOfBirth] DATETIME2 NOT NULL,
    [UserName] NVARCHAR(50) NOT NULL
)

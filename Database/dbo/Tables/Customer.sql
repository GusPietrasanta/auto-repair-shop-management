﻿CREATE TABLE [dbo].[Customer]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [PhoneNumber] NVARCHAR(30) NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL,

)

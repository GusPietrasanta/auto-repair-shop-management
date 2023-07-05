CREATE TABLE [dbo].[Vehicle]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerID] INT NOT NULL, 
    [NumberPlate] NVARCHAR(10) NOT NULL, 
    [Make] NVARCHAR(50) NOT NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [Year] CHAR(4) NOT NULL, 
    [VIN] CHAR(17) NOT NULL, 
    [FuelType] VARCHAR(10) NOT NULL, 
    [TransmissionType] VARCHAR(10) NOT NULL, 
    [EngineDescription] VARCHAR(50) NOT NULL, 
    [BodyType] VARCHAR(50) NOT NULL, 
    [Cylinders] VARCHAR(6) NOT NULL, 
    [SizeLitres] DECIMAL(4, 2) NOT NULL, 
    [FirstVisit] DATETIME2 NULL, 
    CONSTRAINT [FK_Vehicle_Customer] FOREIGN KEY (CustomerID) REFERENCES Customer([ID]) ON DELETE CASCADE
)

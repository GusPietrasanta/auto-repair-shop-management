CREATE TABLE [dbo].[Vehicle]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerID] INT NOT NULL, 
    [Make] NVARCHAR(50) NOT NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [Year] CHAR(4) NOT NULL, 
    [FuelType] VARCHAR(10) NOT NULL, 
    [TransmissionType] VARCHAR(10) NOT NULL, 
    [VIN] NCHAR(17) NOT NULL, 
    [NumberPlate] NVARCHAR(10) NOT NULL, 
    [Cylinders] CHAR(2) NULL, 
    [SizeLitres] DECIMAL(4, 2) NULL, 
    [FirstVisit] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_Vehicle_Customer] FOREIGN KEY (CustomerID) REFERENCES Customer([ID]),
)

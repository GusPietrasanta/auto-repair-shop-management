CREATE TABLE [dbo].[Appointment]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerID] INT NOT NULL, 
    [VehicleID] INT NOT NULL, 
    [Date] DATETIME2 NOT NULL, 
    [MechanicID] INT NULL, 
    [Completed] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Appointment_Customer] FOREIGN KEY ([CustomerID]) REFERENCES Customer([ID]), 
    CONSTRAINT [FK_Appointment_Vehicle] FOREIGN KEY ([VehicleID]) REFERENCES Vehicle([ID]), 
    CONSTRAINT [FK_Appointment_Mechanic] FOREIGN KEY (MechanicID) REFERENCES Mechanic([ID])

)

CREATE TABLE [dbo].[Message]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [MechanicID] INT NOT NULL, 
    [Content] VARCHAR(MAX) NOT NULL, 
    [Tag] VARCHAR(20) NOT NULL, 
    CONSTRAINT [FK_Message_Mechanic] FOREIGN KEY (MechanicID) REFERENCES [Mechanic]([ID])
)

CREATE TABLE [dbo].[Doel]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Omschrijving] NVARCHAR(MAX) NULL, 
    [IsGeheim] BIT NOT NULL DEFAULT 1
	
)

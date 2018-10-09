CREATE TABLE [dbo].[Enemy]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PowerLevel] INT NOT NULL DEFAULT 8999, 
    [Name] NVARCHAR(MAX) NULL, 
    [DungeonId] INT NULL, 
    CONSTRAINT [FK_Enemy_Dungeon] FOREIGN KEY (DungeonId) REFERENCES Dungeon(Id)
)

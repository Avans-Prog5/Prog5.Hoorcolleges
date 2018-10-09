CREATE TABLE [dbo].[IdeeDoel]
(
	[DoelId] INT NOT NULL,
    [IdeeId] INT NOT NULL, 
	PRIMARY KEY (DoelId, IdeeId),
	FOREIGN KEY (DoelId) REFERENCES Doel(Id),
	FOREIGN KEY (IdeeId) REFERENCES Idee(Id)


)

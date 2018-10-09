/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

insert into Enemy (Id, Name) values (1, 'Stijn Smulders')
insert into Enemy (Id, Name) values (2, 'Bob de Bouwer')
insert into Enemy (Id, Name) values (3, 'CEO van Festispec')


insert into Dungeon (Id, Level, Name) values (1, 1000, 'Molten Core')
insert into Dungeon (Id, Level, Name) values (2, 22, 'Den Boesoe')
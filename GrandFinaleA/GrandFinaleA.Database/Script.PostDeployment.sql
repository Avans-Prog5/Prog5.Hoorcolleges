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

--insert into Doel (Id, Omschrijving) values (1, 'Gelukkig worden');
--insert into Doel (Id, Omschrijving) values (2, 'Vlaanderen opnieuw veroveren');
--insert into Doel (Id, Omschrijving) values (3, 'Vriendin fixen');
insert into Doel (Id, Omschrijving, IsGeheim) values (4, '10 Sit-ups fixen', 1);
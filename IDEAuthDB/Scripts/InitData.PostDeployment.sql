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

INSERT INTO [Auth].[ClaimTypes]
VALUES('465B45D8-4AE7-4870-9F34-48BAFED867A0', 'SuperAdmin', 'http://idgiaoduc.vn/claims/superadmin', 0),
('A517B2E8-D236-43B3-A9B2-360D17988B6D', 'Role', 'http://idgiaoduc.vn/claimtype/role', 1),
('C7AFF8BA-FCD1-48BD-B5D5-9962A8070FC7', 'Right', 'http://idgiaoduc.vn/claimtype/right', 1),
('2D3E45C8-6741-42FA-A1B1-8180CFEF4937', 'Owner', 'http://idgiaoduc.vn/claimtype/owner', 1);
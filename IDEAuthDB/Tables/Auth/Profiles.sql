CREATE TABLE [Auth].[Profiles]
(
	[UserAccountId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[DisplayName] NVARCHAR(50) NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Email] VARCHAR(MAX) NULL, 
    [Mobile] VARCHAR(20) NULL,     
    CONSTRAINT [FK_Profiles_UserAccounts] FOREIGN KEY ([UserAccountId]) REFERENCES [Auth].[UserAccounts]([UserAccountId])
)

GO

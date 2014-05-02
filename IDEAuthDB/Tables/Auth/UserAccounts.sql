CREATE TABLE [Auth].[UserAccounts]
(
	[UserAccountId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [PasswordHash] VARCHAR(200) NULL , 
    [Salt] VARCHAR(200) NULL, 
    [Status] TINYINT NOT NULL DEFAULT 0 
)

GO

CREATE UNIQUE INDEX [IX_UserAccounts_UserName] ON [Auth].[UserAccounts] ([UserName])

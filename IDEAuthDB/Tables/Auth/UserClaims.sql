CREATE TABLE [Auth].[UserClaims]
(
	[UserClaimId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [UserAccountId] UNIQUEIDENTIFIER NOT NULL, 
    [ClaimTypeId] UNIQUEIDENTIFIER NOT NULL, 
    [ResourceName] VARCHAR(500) NOT NULL, 
    [Right] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_UserClaims_UserAccounts] FOREIGN KEY ([UserAccountId]) REFERENCES [Auth].[UserAccounts]([UserAccountId]),
	CONSTRAINT [FK_UserClaims_ClaimTypes] FOREIGN KEY ([ClaimTypeId]) REFERENCES [Auth].[ClaimTypes]([ClaimTypeId]) 
)

GO

CREATE UNIQUE INDEX [IX_UserClaims_UserAccountId_ClaimTypeId_ResourceName] ON [Auth].[UserClaims] ([UserAccountId], [ClaimTypeId], [ResourceName])

GO

CREATE INDEX [IX_UserClaims_UserAccountId] ON [Auth].[UserClaims] ([UserAccountId])

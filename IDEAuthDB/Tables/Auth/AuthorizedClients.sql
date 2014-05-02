CREATE TABLE [Auth].[AuthorizedClients]
(
	[AuthorizedClientId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ClientId] VARCHAR(50) NOT NULL, 
    [ClientSecret] VARCHAR(MAX) NOT NULL, 
    [Status] TINYINT NOT NULL DEFAULT 0
)

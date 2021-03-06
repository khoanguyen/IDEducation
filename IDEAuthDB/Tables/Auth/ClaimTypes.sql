﻿CREATE TABLE [Auth].[ClaimTypes]
(
	[ClaimTypeId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ClaimType] NVARCHAR(50) NOT NULL, 
    [ClaimUri] VARCHAR(MAX) NOT NULL, 
    [IsRegularClaim] BIT NOT NULL DEFAULT 1
)

-- attempt to run DROP TABLE only if it exists 
DROP TABLE IF EXISTS [dbo].[Contact];
GO



CREATE TABLE [dbo].[Contact](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [FirstName] [nvarchar](100) NOT NULL,
	[MiddleName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
    [Address] [nvarchar](500) NULL,
    [Phone] [nvarchar](50) NULL,
    [Age] [nvarchar](10) NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED
    (
        [Id] ASC
    )
)
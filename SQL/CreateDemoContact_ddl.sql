-- attempt to run DROP TABLE only if it exists 
DROP TABLE IF EXISTS [dbo].[Contact];
GO



CREATE TABLE [dbo].[Contact](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [nvarchar](100) NOT NULL,
    [Address] [nvarchar](500) NULL,
    [Phone] [nvarchar](50) NULL,
    [Age] [int] NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED
    (
        [Id] ASC
    )
)
CREATE TABLE [dbo].[Users] (
	[Id]   INT           NOT NULL,
    [FirsName] NVARCHAR (50) NULL,
    [LastName] NVARCHAR (50) NULL,
    [Email]    NVARCHAR (50) NULL,
    [Password] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


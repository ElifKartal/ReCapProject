CREATE TABLE [dbo].[Customers] (
    [Id]          INT           NOT NULL primary key,
    [CustomerId]  INT           NULL,
    [UserId]      INT           NULL,
    [CompanyName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


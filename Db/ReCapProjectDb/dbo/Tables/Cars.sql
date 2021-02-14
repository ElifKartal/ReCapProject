CREATE TABLE [dbo].[Cars] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [ColorId]      INT          NULL,
    [BrandId]      INT          NULL,
    [ModelYear]    INT          NULL,
    [DailyPrice]   DECIMAL (18) NULL,
    [Descriptions] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Cars] (
    [CarId]       INT           NOT NULL,
    [CarName]     NVARCHAR (50) NULL,
    [BrandId]     INT           NULL,
    [ColorId]     INT           NULL,
    [DailyPrice]  DECIMAL (18)  NULL,
    [ModelYear]   INT           NULL,
    [Description] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC)
);



DROP TABLE [dbo].[Baskets];

CREATE TABLE [dbo].[Baskets] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [BuyerId] NVARCHAR (256) NOT NULL,
    constraint [basket_id] Primary key ([Id])
);
CREATE INDEX [Baskets_IX_Id] ON [Baskets] ([Id] ASC);
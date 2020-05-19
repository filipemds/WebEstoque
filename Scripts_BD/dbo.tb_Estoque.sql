CREATE TABLE [dbo].[tb_Estoque] (
    [Id]   INT NOT NULL,
    [Qtde] INT NOT NULL,
    [Id_Mercadoria] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tb_Mercadoria_Totb_Estoque_IdMercadoria] FOREIGN KEY ([Id_Mercadoria]) REFERENCES [dbo].[tb_Mercadoria] ([Id])
);


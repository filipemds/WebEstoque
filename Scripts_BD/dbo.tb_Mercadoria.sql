CREATE TABLE [dbo].[tb_Mercadoria]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Descricao] VARCHAR(50) NOT NULL,
	[Qtde_Inicial] INT,
	[Unidade_Medida] VARCHAR(2)
)

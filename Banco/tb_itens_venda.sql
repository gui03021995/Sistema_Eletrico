USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_itens_venda]    Script Date: 31/03/2023 17:34:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_itens_venda](
	[id_item] [int] IDENTITY(1,1) NOT NULL,
	[valor] [varchar](50) NOT NULL,
	[id_venda] [int] NOT NULL,
	[id_produto] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tb_itens_venda] PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_itens_venda]  WITH CHECK ADD  CONSTRAINT [FK_tb_itens_venda_tb_produto] FOREIGN KEY([id_produto])
REFERENCES [dbo].[tb_produto] ([id_produto])
GO

ALTER TABLE [dbo].[tb_itens_venda] CHECK CONSTRAINT [FK_tb_itens_venda_tb_produto]
GO

ALTER TABLE [dbo].[tb_itens_venda]  WITH CHECK ADD  CONSTRAINT [FK_tb_itens_venda_tb_venda] FOREIGN KEY([id_venda])
REFERENCES [dbo].[tb_venda] ([id_venda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[tb_itens_venda] CHECK CONSTRAINT [FK_tb_itens_venda_tb_venda]
GO


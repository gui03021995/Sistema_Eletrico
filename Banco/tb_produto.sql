USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_produto]    Script Date: 31/03/2023 17:34:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_produto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[desc_produto] [varchar](50) NOT NULL,
	[valor] [varchar](50) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tb_produto] PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_produto]  WITH CHECK ADD  CONSTRAINT [FK_tb_produto_tb_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[tb_categoria] ([id_categoria])
GO

ALTER TABLE [dbo].[tb_produto] CHECK CONSTRAINT [FK_tb_produto_tb_categoria]
GO


USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_venda]    Script Date: 31/03/2023 17:35:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_venda](
	[id_venda] [int] IDENTITY(1,1) NOT NULL,
	[valor] [varchar](50) NOT NULL,
	[desconto] [varchar](50) NOT NULL,
	[cod_venda] [int] NULL,
	[id_pessoa_cliente] [int] NULL,
	[id_pessoa_funcionario] [int] NULL,
	[cod_prod] [int] NULL,
 CONSTRAINT [PK_tb_vendas] PRIMARY KEY CLUSTERED 
(
	[id_venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


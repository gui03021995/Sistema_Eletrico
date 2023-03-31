USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_pessoas]    Script Date: 31/03/2023 17:34:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_pessoas](
	[id_pessoas] [int] IDENTITY(1,1) NOT NULL,
	[data_nascimento] [datetime] NOT NULL,
	[CPF_CNPJ] [varchar](16) NOT NULL,
	[data_cadastro] [datetime] NOT NULL,
	[situacao_cadastro] [varchar](10) NOT NULL,
	[tipo_cadastro] [varchar](18) NOT NULL,
	[cargo] [varchar](50) NULL,
	[sexo] [varchar](12) NULL,
	[setor] [varchar](50) NULL,
	[nome_pessoa] [varchar](75) NOT NULL,
	[contato] [varchar](75) NOT NULL,
	[email] [varchar](75) NOT NULL,
	[data_admissao] [datetime] NULL,
 CONSTRAINT [PK_tb_pessoas] PRIMARY KEY CLUSTERED 
(
	[id_pessoas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


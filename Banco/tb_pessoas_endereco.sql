USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_pessoas_endereco]    Script Date: 31/03/2023 17:34:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_pessoas_endereco](
	[id_endereco] [int] IDENTITY(1,1) NOT NULL,
	[tp_endereco1] [varchar](50) NOT NULL,
	[endereco1] [varchar](50) NOT NULL,
	[id_pessoas] [int] NOT NULL,
	[tp_endereco2] [varchar](50) NULL,
	[endereco2] [varchar](50) NULL,
 CONSTRAINT [tb_pessoa_endereco] PRIMARY KEY CLUSTERED 
(
	[id_endereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


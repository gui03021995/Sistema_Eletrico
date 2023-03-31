USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_categoria]    Script Date: 31/03/2023 17:33:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[desc_categoria] [varchar](50) NOT NULL,
	[nome_categoria] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


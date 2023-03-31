USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_usuario]    Script Date: 31/03/2023 17:35:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_usuario](
	[usuario] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL,
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[id_pessoas] [int] NOT NULL,
 CONSTRAINT [PK_tb_usuario] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_status]    Script Date: 31/03/2023 17:35:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_status](
	[id_status] [int] IDENTITY(1,1) NOT NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tb_status] PRIMARY KEY CLUSTERED 
(
	[id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [dbEletric]
GO

/****** Object:  Table [dbo].[tb_contas_receber]    Script Date: 31/03/2023 17:34:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_contas_receber](
	[id_conta] [int] IDENTITY(1,1) NOT NULL,
	[data_compra] [varchar](50) NOT NULL,
	[data_vencimento] [varchar](50) NOT NULL,
	[data_pagamento] [varchar](50) NOT NULL,
	[id_status] [int] NOT NULL,
	[id_venda] [int] NOT NULL,
 CONSTRAINT [PK_tb_contas_receber] PRIMARY KEY CLUSTERED 
(
	[id_conta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_contas_receber]  WITH CHECK ADD  CONSTRAINT [FK_tb_contas_receber_tb_status] FOREIGN KEY([id_status])
REFERENCES [dbo].[tb_status] ([id_status])
GO

ALTER TABLE [dbo].[tb_contas_receber] CHECK CONSTRAINT [FK_tb_contas_receber_tb_status]
GO

ALTER TABLE [dbo].[tb_contas_receber]  WITH CHECK ADD  CONSTRAINT [FK_tb_contas_receber_tb_venda] FOREIGN KEY([id_venda])
REFERENCES [dbo].[tb_venda] ([id_venda])
GO

ALTER TABLE [dbo].[tb_contas_receber] CHECK CONSTRAINT [FK_tb_contas_receber_tb_venda]
GO


USE [DW.Billing]
GO

/****** Object:  Table [dbo].[Tbl_Detalle_Factura]    Script Date: 18/07/2021 8:02:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Detalle_Factura](
	[Cod_Factura] [varchar](20) NOT NULL,
	[Codigo_producto] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[Total] [decimal](10, 0) NULL,
 CONSTRAINT [PK_Tbl_Detalle_Factura] PRIMARY KEY CLUSTERED 
(
	[Cod_Factura] ASC,
	[Codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


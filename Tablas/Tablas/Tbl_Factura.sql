USE [DW.Billing]
GO

/****** Object:  Table [dbo].[Tbl_Factura]    Script Date: 18/07/2021 7:55:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Factura](
	[Num_Factura] [varchar](20) NOT NULL,
	[Codigo_cliente] [varchar](15) NULL,
	[Nombre_Empleado] [varchar](30) NULL,
	[Fecha_Facturacion] [datetime] NULL,
	[Total_Factura] [decimal](10, 0) NULL,
	[IVA] [decimal](10, 0) NULL,
	[Estado] [varchar](1) NULL,
 CONSTRAINT [PK_Tbl_Factura] PRIMARY KEY CLUSTERED 
(
	[Num_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


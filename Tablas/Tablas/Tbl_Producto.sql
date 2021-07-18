USE [DW.Billing]
GO

/****** Object:  Table [dbo].[Tbl_Producto]    Script Date: 18/07/2021 8:06:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Producto](
	[Id_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NULL,
	[Precio] [int] NULL,
	[Stock] [int] NULL,
	[Fecha_ingreso] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Producto] PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



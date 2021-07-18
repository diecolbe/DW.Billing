USE [DW.Billing]
GO

/****** Object:  Table [dbo].[Tbl_TipoDocumento]    Script Date: 18/07/2021 8:09:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_TipoDocumento](
	[Id_Tipo_documento] [int] NOT NULL,
	[Descripcion] [varchar](30) NULL,
 CONSTRAINT [PK_Tbl_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[Id_Tipo_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

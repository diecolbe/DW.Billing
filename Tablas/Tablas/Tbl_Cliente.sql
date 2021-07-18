USE [DW.Billing]
GO

/****** Object:  Table [dbo].[Tbl_Cliente]    Script Date: 18/07/2021 8:00:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Cliente](
	[Documento] [varchar](15) NOT NULL,
	[Cod_tipo_documento] [int] NULL,
	[Nombres] [varchar](30) NULL,
	[Apellidos] [varchar](30) NULL,
	[Direccion] [varchar](20) NULL,
	[Telefono] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[Fecha_Nacimiento] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Cliente] PRIMARY KEY CLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



USE [consultorio_odontologico]
GO
/****** Object:  Table [dbo].[consulta]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consulta](
	[id_consulta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[id_paciente] [int] NULL,
	[cobrado] [bit] NULL,
	[id_profesional] [int] NULL,
	[monto] [float] NULL,
	[num_turno] [int] NOT NULL,
	[observacion] [varchar](max) NULL,
 CONSTRAINT [PK_consulta] PRIMARY KEY CLUSTERED 
(
	[id_consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[disponibilidad_profesional]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[disponibilidad_profesional](
	[matricula] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[disponible] [bit] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_disponibilidad_profesional] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC,
	[fecha] ASC,
	[hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historial_clinico]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historial_clinico](
	[id_historial] [int] IDENTITY(1,1) NOT NULL,
	[id_paciente] [int] NOT NULL,
	[fecha_consulta] [date] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_historial_clinico] PRIMARY KEY CLUSTERED 
(
	[id_historial] ASC,
	[id_paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historial_turnos]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historial_turnos](
	[id_historial] [int] IDENTITY(1,1) NOT NULL,
	[num_turno] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[id_paciente] [int] NULL,
	[fecha] [date] NULL,
	[hora] [time](7) NULL,
	[id_profesional] [int] NULL,
 CONSTRAINT [PK_historial_turnos_1] PRIMARY KEY CLUSTERED 
(
	[id_historial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[insumo]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[insumo](
	[id_insumo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado] [bit] NULL,
	[stock] [int] NULL,
 CONSTRAINT [PK_insumo] PRIMARY KEY CLUSTERED 
(
	[id_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[insumo_x_practica]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[insumo_x_practica](
	[id_practica] [int] NOT NULL,
	[id_insumo] [int] NOT NULL,
	[cantidad] [int] NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_insumo_x_practica] PRIMARY KEY CLUSTERED 
(
	[id_practica] ASC,
	[id_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[obra_social]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[obra_social](
	[cod_obra_social] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado] [bit] NULL,
	[porcentaje] [float] NULL,
 CONSTRAINT [PK_obra_social] PRIMARY KEY CLUSTERED 
(
	[cod_obra_social] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paciente]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paciente](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
	[borrado] [bit] NOT NULL,
	[telefono] [varchar](50) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_paciente] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[practica]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[practica](
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](max) NULL,
	[importe] [int] NULL,
	[id_practica] [int] IDENTITY(1,1) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_practica] PRIMARY KEY CLUSTERED 
(
	[id_practica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pracXcons]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pracXcons](
	[id_consulta] [int] NOT NULL,
	[id_practica] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesional]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesional](
	[matricula] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
	[id_usuario] [int] NULL,
	[borrado] [bit] NULL,
	[especialidad] [varchar](50) NULL,
 CONSTRAINT [PK_profesional] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[turno]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turno](
	[num_turno] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[hora] [time](7) NULL,
	[id_paciente] [int] NOT NULL,
	[id_profesional] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
	[id_obra_social] [int] NOT NULL,
	[observacion] [varchar](500) NULL,
 CONSTRAINT [PK_turno] PRIMARY KEY CLUSTERED 
(
	[num_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 13/11/2020 23:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[consulta] ON 

INSERT [dbo].[consulta] ([id_consulta], [fecha], [id_paciente], [cobrado], [id_profesional], [monto], [num_turno], [observacion]) VALUES (7, CAST(N'2020-10-14' AS Date), 42244266, 0, 3, 11750, 4, N'')
SET IDENTITY_INSERT [dbo].[consulta] OFF
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'10:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'11:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'13:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-07' AS Date), CAST(N'13:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'11:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'11:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'12:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'12:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'13:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-14' AS Date), CAST(N'13:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'12:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-21' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'10:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-09-28' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'11:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'11:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'12:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-05' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'11:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'11:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'12:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'12:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'13:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-12' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-19' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-10-26' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-02' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'10:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'11:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'12:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-09' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-16' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-23' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-11-30' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-07' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-14' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (1, CAST(N'2020-12-21' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-01' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'10:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-08' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'11:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'11:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'13:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-15' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-22' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-09-29' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-06' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-13' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-20' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-10-27' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-03' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'09:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'10:00:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'10:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-10' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-17' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-11-24' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-01' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-08' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-15' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (2, CAST(N'2020-12-22' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-02' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-16' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-23' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-09-30' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-07' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'10:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-14' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-21' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-10-28' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-04' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-11' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-18' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-11-25' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-02' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-09' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-16' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (3, CAST(N'2020-12-23' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-03' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-10' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-17' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-09-24' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-01' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-08' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-15' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-22' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-10-29' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-05' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-12' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-19' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-11-26' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-03' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-10' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-17' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (4, CAST(N'2020-12-24' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-04' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-11' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-18' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-09-25' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-02' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-09' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'09:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'10:30:00' AS Time), 0, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-16' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-23' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-10-30' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-06' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-20' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-11-27' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-04' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-11' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-18' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'09:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'09:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'10:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'10:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'11:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'11:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'12:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'12:30:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'13:00:00' AS Time), 1, 0)
INSERT [dbo].[disponibilidad_profesional] ([matricula], [fecha], [hora], [disponible], [borrado]) VALUES (5, CAST(N'2020-12-25' AS Date), CAST(N'13:30:00' AS Time), 1, 0)
GO
SET IDENTITY_INSERT [dbo].[historial_clinico] ON 

INSERT [dbo].[historial_clinico] ([id_historial], [id_paciente], [fecha_consulta], [id_consulta], [borrado]) VALUES (1, 42244266, CAST(N'2020-10-14' AS Date), 7, 0)
SET IDENTITY_INSERT [dbo].[historial_clinico] OFF
GO
SET IDENTITY_INSERT [dbo].[historial_turnos] ON 

INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1, 1, 0, N'creado', 42258136, CAST(N'2020-10-12' AS Date), CAST(N'09:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (4, 2, 0, N'creado', 42258136, CAST(N'2020-10-12' AS Date), CAST(N'10:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (5, 3, 0, N'creado', 42244266, CAST(N'2020-10-13' AS Date), CAST(N'10:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (6, 3, 0, N'cancelado', 42244266, CAST(N'2020-10-13' AS Date), CAST(N'10:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (7, 3, 0, N'modificado', 42244266, CAST(N'2020-10-13' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (8, 3, 0, N'cancelado', 42244266, CAST(N'2020-10-13' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (9, 3, 0, N'modificado', 42244266, CAST(N'2020-10-13' AS Date), CAST(N'09:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (10, 3, 0, N'cancelado', 42244266, CAST(N'2020-10-13' AS Date), CAST(N'09:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (11, 4, 0, N'creado', 42244266, CAST(N'2020-10-14' AS Date), CAST(N'10:30:00' AS Time), 3)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (12, 1, 0, N'modificado', 42258136, CAST(N'2020-10-12' AS Date), CAST(N'09:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (13, 1, 0, N'modificado', 42258136, CAST(N'2020-10-12' AS Date), CAST(N'09:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (14, 5, 0, N'creado', 44848946, CAST(N'2020-10-13' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (15, 5, 0, N'modificado', 44848946, CAST(N'2020-10-13' AS Date), CAST(N'09:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (16, 3, 0, N'modificado', 42244266, CAST(N'2020-10-16' AS Date), CAST(N'09:30:00' AS Time), 5)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (17, 3, 0, N'modificado', 42244266, CAST(N'2020-10-13' AS Date), CAST(N'09:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (18, 3, 0, N'modificado', 42244266, CAST(N'2020-10-16' AS Date), CAST(N'09:30:00' AS Time), 5)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (19, 3, 0, N'cancelado', 42244266, CAST(N'2020-10-16' AS Date), CAST(N'09:30:00' AS Time), 5)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (20, 1, 0, N'modificado', 42258136, CAST(N'2020-10-16' AS Date), CAST(N'09:30:00' AS Time), 5)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (21, 6, 0, N'creado', 42258136, CAST(N'2020-10-16' AS Date), CAST(N'10:30:00' AS Time), 5)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (22, 2, 0, N'cancelado', 42258136, CAST(N'2020-10-12' AS Date), CAST(N'10:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (23, 5, 0, N'modificado', 44848946, CAST(N'2020-10-13' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (24, 5, 0, N'modificado', 44848946, CAST(N'2020-10-12' AS Date), CAST(N'13:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1021, 1006, 0, N'creado', 42258136, CAST(N'2020-10-15' AS Date), CAST(N'09:30:00' AS Time), 4)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1022, 1007, 0, N'creado', 42896325, CAST(N'2020-09-07' AS Date), CAST(N'09:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1023, 1008, 0, N'creado', 45689596, CAST(N'2020-09-07' AS Date), CAST(N'11:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1024, 1009, 0, N'creado', 54258211, CAST(N'2020-09-07' AS Date), CAST(N'10:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1025, 1010, 0, N'creado', 95852366, CAST(N'2020-09-07' AS Date), CAST(N'09:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1026, 1011, 0, N'creado', 54258211, CAST(N'2020-09-07' AS Date), CAST(N'13:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1027, 1012, 0, N'creado', 42895246, CAST(N'2020-09-07' AS Date), CAST(N'13:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1028, 1013, 0, N'creado', 42895246, CAST(N'2020-09-14' AS Date), CAST(N'09:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1029, 1014, 0, N'creado', 43582569, CAST(N'2020-09-14' AS Date), CAST(N'10:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1030, 1015, 0, N'creado', 54258211, CAST(N'2020-09-14' AS Date), CAST(N'11:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1031, 1016, 0, N'creado', 45868992, CAST(N'2020-09-14' AS Date), CAST(N'11:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1032, 1017, 0, N'creado', 89525566, CAST(N'2020-09-14' AS Date), CAST(N'12:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1033, 1018, 0, N'creado', 42896325, CAST(N'2020-09-14' AS Date), CAST(N'12:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1034, 1019, 0, N'creado', 42244266, CAST(N'2020-09-14' AS Date), CAST(N'13:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1035, 1020, 0, N'creado', 45689596, CAST(N'2020-09-14' AS Date), CAST(N'13:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1036, 1021, 0, N'creado', 45689596, CAST(N'2020-09-21' AS Date), CAST(N'10:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1037, 1022, 0, N'creado', 42896325, CAST(N'2020-09-21' AS Date), CAST(N'09:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1038, 1023, 0, N'creado', 42258136, CAST(N'2020-09-21' AS Date), CAST(N'09:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1039, 1024, 0, N'creado', 45868992, CAST(N'2020-09-21' AS Date), CAST(N'12:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1040, 1025, 0, N'creado', 43582569, CAST(N'2020-09-28' AS Date), CAST(N'09:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1041, 1026, 0, N'creado', 44848946, CAST(N'2020-09-28' AS Date), CAST(N'09:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1042, 1027, 0, N'creado', 95852366, CAST(N'2020-09-28' AS Date), CAST(N'10:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1043, 1028, 0, N'creado', 45689596, CAST(N'2020-09-28' AS Date), CAST(N'10:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1044, 1029, 0, N'creado', 42896325, CAST(N'2020-10-05' AS Date), CAST(N'09:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1045, 1030, 0, N'creado', 42244266, CAST(N'2020-10-05' AS Date), CAST(N'11:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1046, 1031, 0, N'creado', 42895246, CAST(N'2020-10-05' AS Date), CAST(N'11:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1047, 1032, 0, N'creado', 95852366, CAST(N'2020-10-05' AS Date), CAST(N'12:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1048, 1033, 0, N'creado', 95852366, CAST(N'2020-10-12' AS Date), CAST(N'10:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1049, 1034, 0, N'creado', 45689596, CAST(N'2020-10-12' AS Date), CAST(N'11:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1050, 1035, 0, N'creado', 44848946, CAST(N'2020-10-12' AS Date), CAST(N'11:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1051, 1036, 0, N'creado', 45868992, CAST(N'2020-10-12' AS Date), CAST(N'12:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1052, 1037, 0, N'creado', 89525566, CAST(N'2020-10-12' AS Date), CAST(N'12:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1053, 1038, 0, N'creado', 89525566, CAST(N'2020-09-01' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1054, 1039, 0, N'creado', 54258211, CAST(N'2020-09-01' AS Date), CAST(N'09:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1055, 1040, 0, N'creado', 45689596, CAST(N'2020-09-08' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1056, 1041, 0, N'creado', 54258211, CAST(N'2020-09-08' AS Date), CAST(N'09:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1057, 1042, 0, N'creado', 46982548, CAST(N'2020-09-08' AS Date), CAST(N'10:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1058, 1043, 0, N'creado', 46982548, CAST(N'2020-09-15' AS Date), CAST(N'09:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1059, 1044, 0, N'creado', 95852366, CAST(N'2020-09-15' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1060, 1045, 0, N'creado', 42244266, CAST(N'2020-09-15' AS Date), CAST(N'09:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1061, 1046, 0, N'creado', 44848946, CAST(N'2020-09-15' AS Date), CAST(N'11:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1062, 1047, 0, N'creado', 43582569, CAST(N'2020-09-15' AS Date), CAST(N'11:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1063, 1048, 0, N'creado', 46982548, CAST(N'2020-09-15' AS Date), CAST(N'13:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1064, 1049, 0, N'creado', 89525566, CAST(N'2020-09-22' AS Date), CAST(N'09:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1065, 1050, 0, N'creado', 45868992, CAST(N'2020-09-22' AS Date), CAST(N'09:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1066, 1051, 0, N'creado', 45868992, CAST(N'2020-09-22' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1067, 1052, 0, N'creado', 42896325, CAST(N'2020-11-09' AS Date), CAST(N'12:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1068, 1053, 0, N'creado', 44848946, CAST(N'2020-11-09' AS Date), CAST(N'09:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1069, 1054, 0, N'creado', 45868992, CAST(N'2020-11-09' AS Date), CAST(N'10:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1070, 1055, 0, N'creado', 43582569, CAST(N'2020-11-09' AS Date), CAST(N'10:00:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1071, 1056, 0, N'creado', 95852366, CAST(N'2020-11-09' AS Date), CAST(N'11:30:00' AS Time), 1)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1072, 1057, 0, N'creado', 95852366, CAST(N'2020-11-10' AS Date), CAST(N'09:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1073, 1058, 0, N'creado', 42896325, CAST(N'2020-11-10' AS Date), CAST(N'09:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1074, 1059, 0, N'creado', 54258211, CAST(N'2020-11-10' AS Date), CAST(N'10:00:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1075, 1060, 0, N'creado', 42895246, CAST(N'2020-11-10' AS Date), CAST(N'10:30:00' AS Time), 2)
INSERT [dbo].[historial_turnos] ([id_historial], [num_turno], [borrado], [estado], [id_paciente], [fecha], [hora], [id_profesional]) VALUES (1076, 4, 0, N'consulta realizada', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[historial_turnos] OFF
GO
SET IDENTITY_INSERT [dbo].[insumo] ON 

INSERT [dbo].[insumo] ([id_insumo], [nombre], [borrado], [stock]) VALUES (1, N'Composites dentales', 0, 15)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [borrado], [stock]) VALUES (2, N'Guantes desechables', 0, 150)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [borrado], [stock]) VALUES (3, N'Servilletas babero', 0, 50)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [borrado], [stock]) VALUES (4, N'Fresas dentales', 0, 100)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [borrado], [stock]) VALUES (5, N'Material de encodoncia', 0, 60)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [borrado], [stock]) VALUES (6, N'Material de ortodoncia', 0, 100)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [borrado], [stock]) VALUES (7, N'Suturas para odontologia', 0, 150)
SET IDENTITY_INSERT [dbo].[insumo] OFF
GO
INSERT [dbo].[insumo_x_practica] ([id_practica], [id_insumo], [cantidad], [borrado]) VALUES (6, 1, 20, 0)
INSERT [dbo].[insumo_x_practica] ([id_practica], [id_insumo], [cantidad], [borrado]) VALUES (6, 3, 25, 0)
INSERT [dbo].[insumo_x_practica] ([id_practica], [id_insumo], [cantidad], [borrado]) VALUES (7, 4, 3, 0)
INSERT [dbo].[insumo_x_practica] ([id_practica], [id_insumo], [cantidad], [borrado]) VALUES (7, 5, 8, 0)
GO
SET IDENTITY_INSERT [dbo].[obra_social] ON 

INSERT [dbo].[obra_social] ([cod_obra_social], [nombre], [borrado], [porcentaje]) VALUES (1, N'OSDE', 0, 0.45)
INSERT [dbo].[obra_social] ([cod_obra_social], [nombre], [borrado], [porcentaje]) VALUES (2, N'Medife', 0, 0.4)
INSERT [dbo].[obra_social] ([cod_obra_social], [nombre], [borrado], [porcentaje]) VALUES (3, N'PAMI', 0, 0.3)
INSERT [dbo].[obra_social] ([cod_obra_social], [nombre], [borrado], [porcentaje]) VALUES (4, N'Union Personal', 0, 0.35)
SET IDENTITY_INSERT [dbo].[obra_social] OFF
GO
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (42244266, N'Geraldine', N'Lopez', N'Humberto Primo 562', 0, N'3515548898', N'gl@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (42258136, N'Jose', N'Camaño', N'General Paz 700', 0, N'3513538854', N'jc@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (42895246, N'Jesica', N'Morales', N'cordoba Paz 784', 0, N'3518854586', N'jm@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (42896325, N'Damian', N'Ordoñez', N'Mexico 852', 0, N'35145982672', N'do@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (43582569, N'Soledad', N'Baudo', N'9 de julio 5827', 0, N'3518527967', N'sb@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (44848946, N'Uriel', N'Mendez', N'Obispo Oro 695', 0, N'3515465245', N'um@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (45636981, N'Rodolfo', N'Carreño', N'Tucumán 562', 0, N'3515299531', N'rc@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (45689596, N'Agustina', N'Posse', N'Corrientes 4855', 0, N'35196582163', N'ag@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (45868992, N'Francisco', N'Toledo', N'Almafuerte 6982', 0, N'35196752001', N'ft@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (46982548, N'Facundo', N'Martinez', N'Humberto 698', 0, N'35196721875', N'fm@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (54258211, N'Federico', N'Juarez', N'Del Campo 8965', 0, N'35196820130', N'ap@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (89525566, N'Felipe', N'Sandoval', N'Elcano 89658', 0, N'3515286902', N'fs@gmail.com')
INSERT [dbo].[paciente] ([dni], [nombre], [apellido], [domicilio], [borrado], [telefono], [email]) VALUES (95852366, N'Candela', N'Paz', N'Independencia 5896', 0, N'3516645023', N'cp@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[practica] ON 

INSERT [dbo].[practica] ([nombre], [descripcion], [importe], [id_practica], [borrado]) VALUES (N'Control', N'Control de cualquier otra practica realizada', 2000, 6, 0)
INSERT [dbo].[practica] ([nombre], [descripcion], [importe], [id_practica], [borrado]) VALUES (N'Endodoncia', N'Técnica utilizada para tratar las enfermedades dentarias', 500, 7, 0)
INSERT [dbo].[practica] ([nombre], [descripcion], [importe], [id_practica], [borrado]) VALUES (N'Ortodoncia', N'Estudio, prevención, diagnóstico y tratamiento de las anomalías de forma, posición, relación y función', 25000, 8, 0)
INSERT [dbo].[practica] ([nombre], [descripcion], [importe], [id_practica], [borrado]) VALUES (N'Extraccion', N'Cirugía oral que se ocupa de practicar la extracción de un diente o porción', 1000, 9, 0)
INSERT [dbo].[practica] ([nombre], [descripcion], [importe], [id_practica], [borrado]) VALUES (N'Limpieza', N'Higiene oral e involucra la remoción de la placa dental de los dientes', 2000, 10, 0)
INSERT [dbo].[practica] ([nombre], [descripcion], [importe], [id_practica], [borrado]) VALUES (N'Protesis', N'Extensión artificial que reemplaza o provee una parte del diente', 15000, 11, 0)
INSERT [dbo].[practica] ([nombre], [descripcion], [importe], [id_practica], [borrado]) VALUES (N'Consulta', N'Primera cosulta para poder indicar la razon del contacto', 1500, 12, 0)
SET IDENTITY_INSERT [dbo].[practica] OFF
GO
INSERT [dbo].[pracXcons] ([id_consulta], [id_practica]) VALUES (7, 8)
GO
SET IDENTITY_INSERT [dbo].[profesional] ON 

INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (1, N'Andrea', N'Gomez', N'Dean Funes 5880', NULL, 0, N'Ortodoncista')
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (2, N'Juan', N'Perez', N'General Paz 2000', NULL, 0, NULL)
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (3, N'Marcelo', N'Lopez', N'Progreso 6582', NULL, 0, NULL)
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (4, N'Guadalupe', N'Arenales', N'Cervantes 5880', NULL, 0, NULL)
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (5, N'Isabel', N'Diaz', N'Rivera Indarte 3681', NULL, 0, N'')
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (6, N'qwdq', N'qwdqd', N'qdwqd', NULL, 1, N'wdqd')
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (7, N'', N'', N'', NULL, 0, N'')
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (8, N'', N'', N'', NULL, 0, N'')
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (9, N'', N'', N'', NULL, 0, N'')
INSERT [dbo].[profesional] ([matricula], [nombre], [apellido], [domicilio], [id_usuario], [borrado], [especialidad]) VALUES (10, N'', N'', N'', NULL, 0, N'')
SET IDENTITY_INSERT [dbo].[profesional] OFF
GO
SET IDENTITY_INSERT [dbo].[turno] ON 

INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1, CAST(N'2020-10-16' AS Date), CAST(N'09:30:00' AS Time), 42258136, 5, 0, 1, N'Es diabetico')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (2, CAST(N'2020-10-12' AS Date), CAST(N'10:00:00' AS Time), 42258136, 1, 1, 1, N'No hay observaciones')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (3, CAST(N'2020-10-16' AS Date), CAST(N'09:30:00' AS Time), 42244266, 5, 1, 1, N'No hay observaciones')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (4, CAST(N'2020-10-14' AS Date), CAST(N'10:30:00' AS Time), 42244266, 3, 0, 1, N'No hay observaciones')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (5, CAST(N'2020-10-12' AS Date), CAST(N'13:00:00' AS Time), 44848946, 1, 0, 2, N'N/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (6, CAST(N'2020-10-16' AS Date), CAST(N'10:30:00' AS Time), 42258136, 5, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1006, CAST(N'2020-10-15' AS Date), CAST(N'09:30:00' AS Time), 42258136, 4, 0, 2, N'N/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1007, CAST(N'2020-09-07' AS Date), CAST(N'09:30:00' AS Time), 42896325, 1, 0, 4, N'diabetico')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1008, CAST(N'2020-09-07' AS Date), CAST(N'11:00:00' AS Time), 45689596, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1009, CAST(N'2020-09-07' AS Date), CAST(N'10:30:00' AS Time), 54258211, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1010, CAST(N'2020-09-07' AS Date), CAST(N'09:00:00' AS Time), 95852366, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1011, CAST(N'2020-09-07' AS Date), CAST(N'13:00:00' AS Time), 54258211, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1012, CAST(N'2020-09-07' AS Date), CAST(N'13:30:00' AS Time), 42895246, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1013, CAST(N'2020-09-14' AS Date), CAST(N'09:00:00' AS Time), 42895246, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1014, CAST(N'2020-09-14' AS Date), CAST(N'10:00:00' AS Time), 43582569, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1015, CAST(N'2020-09-14' AS Date), CAST(N'11:00:00' AS Time), 54258211, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1016, CAST(N'2020-09-14' AS Date), CAST(N'11:30:00' AS Time), 45868992, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1017, CAST(N'2020-09-14' AS Date), CAST(N'12:00:00' AS Time), 89525566, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1018, CAST(N'2020-09-14' AS Date), CAST(N'12:30:00' AS Time), 42896325, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1019, CAST(N'2020-09-14' AS Date), CAST(N'13:00:00' AS Time), 42244266, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1020, CAST(N'2020-09-14' AS Date), CAST(N'13:30:00' AS Time), 45689596, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1021, CAST(N'2020-09-21' AS Date), CAST(N'10:00:00' AS Time), 45689596, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1022, CAST(N'2020-09-21' AS Date), CAST(N'09:00:00' AS Time), 42896325, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1023, CAST(N'2020-09-21' AS Date), CAST(N'09:30:00' AS Time), 42258136, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1024, CAST(N'2020-09-21' AS Date), CAST(N'12:30:00' AS Time), 45868992, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1025, CAST(N'2020-09-28' AS Date), CAST(N'09:00:00' AS Time), 43582569, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1026, CAST(N'2020-09-28' AS Date), CAST(N'09:30:00' AS Time), 44848946, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1027, CAST(N'2020-09-28' AS Date), CAST(N'10:00:00' AS Time), 95852366, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1028, CAST(N'2020-09-28' AS Date), CAST(N'10:30:00' AS Time), 45689596, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1029, CAST(N'2020-10-05' AS Date), CAST(N'09:00:00' AS Time), 42896325, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1030, CAST(N'2020-10-05' AS Date), CAST(N'11:00:00' AS Time), 42244266, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1031, CAST(N'2020-10-05' AS Date), CAST(N'11:30:00' AS Time), 42895246, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1032, CAST(N'2020-10-05' AS Date), CAST(N'12:00:00' AS Time), 95852366, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1033, CAST(N'2020-10-12' AS Date), CAST(N'10:00:00' AS Time), 95852366, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1034, CAST(N'2020-10-12' AS Date), CAST(N'11:00:00' AS Time), 45689596, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1035, CAST(N'2020-10-12' AS Date), CAST(N'11:30:00' AS Time), 44848946, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1036, CAST(N'2020-10-12' AS Date), CAST(N'12:30:00' AS Time), 45868992, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1037, CAST(N'2020-10-12' AS Date), CAST(N'12:00:00' AS Time), 89525566, 1, 0, 4, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1038, CAST(N'2020-09-01' AS Date), CAST(N'10:00:00' AS Time), 89525566, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1039, CAST(N'2020-09-01' AS Date), CAST(N'09:00:00' AS Time), 54258211, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1040, CAST(N'2020-09-08' AS Date), CAST(N'10:00:00' AS Time), 45689596, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1041, CAST(N'2020-09-08' AS Date), CAST(N'09:30:00' AS Time), 54258211, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1042, CAST(N'2020-09-08' AS Date), CAST(N'10:30:00' AS Time), 46982548, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1043, CAST(N'2020-09-15' AS Date), CAST(N'09:30:00' AS Time), 46982548, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1044, CAST(N'2020-09-15' AS Date), CAST(N'10:00:00' AS Time), 95852366, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1045, CAST(N'2020-09-15' AS Date), CAST(N'09:00:00' AS Time), 42244266, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1046, CAST(N'2020-09-15' AS Date), CAST(N'11:00:00' AS Time), 44848946, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1047, CAST(N'2020-09-15' AS Date), CAST(N'11:30:00' AS Time), 43582569, 2, 0, 3, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1048, CAST(N'2020-09-15' AS Date), CAST(N'13:00:00' AS Time), 46982548, 2, 0, 1, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1049, CAST(N'2020-09-22' AS Date), CAST(N'09:30:00' AS Time), 89525566, 2, 0, 1, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1050, CAST(N'2020-09-22' AS Date), CAST(N'09:00:00' AS Time), 45868992, 2, 0, 1, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1051, CAST(N'2020-09-22' AS Date), CAST(N'10:00:00' AS Time), 45868992, 2, 0, 2, N'N/A')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1052, CAST(N'2020-11-09' AS Date), CAST(N'12:30:00' AS Time), 42896325, 1, 0, 4, N'n/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1053, CAST(N'2020-11-09' AS Date), CAST(N'09:30:00' AS Time), 44848946, 1, 0, 2, N'n/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1054, CAST(N'2020-11-09' AS Date), CAST(N'10:30:00' AS Time), 45868992, 1, 0, 4, N'n/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1055, CAST(N'2020-11-09' AS Date), CAST(N'10:00:00' AS Time), 43582569, 1, 0, 1, N'n/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1056, CAST(N'2020-11-09' AS Date), CAST(N'11:30:00' AS Time), 95852366, 1, 0, 2, N'n/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1057, CAST(N'2020-11-10' AS Date), CAST(N'09:00:00' AS Time), 95852366, 2, 0, 1, N'n/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1058, CAST(N'2020-11-10' AS Date), CAST(N'09:30:00' AS Time), 42896325, 2, 0, 1, N'n/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1059, CAST(N'2020-11-10' AS Date), CAST(N'10:00:00' AS Time), 54258211, 2, 0, 1, N'n/a')
INSERT [dbo].[turno] ([num_turno], [fecha], [hora], [id_paciente], [id_profesional], [borrado], [id_obra_social], [observacion]) VALUES (1060, CAST(N'2020-11-10' AS Date), CAST(N'10:30:00' AS Time), 42895246, 2, 0, 1, N'n/a')
SET IDENTITY_INSERT [dbo].[turno] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [contraseña], [borrado]) VALUES (1, N'Administrador', N'123', 0)
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [contraseña], [borrado]) VALUES (2, N'Secretaria', N'456', 0)
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [contraseña], [borrado]) VALUES (3, N'Odontologo', N'789', 0)
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [contraseña], [borrado]) VALUES (4, N'Programador', N'960', 0)
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [contraseña], [borrado]) VALUES (5, N'', N'', 1)
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD  CONSTRAINT [FK_consulta_consulta1] FOREIGN KEY([id_profesional])
REFERENCES [dbo].[profesional] ([matricula])
GO
ALTER TABLE [dbo].[consulta] CHECK CONSTRAINT [FK_consulta_consulta1]
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD  CONSTRAINT [FK_consulta_paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[paciente] ([dni])
GO
ALTER TABLE [dbo].[consulta] CHECK CONSTRAINT [FK_consulta_paciente]
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD  CONSTRAINT [FK_consulta_turno] FOREIGN KEY([num_turno])
REFERENCES [dbo].[turno] ([num_turno])
GO
ALTER TABLE [dbo].[consulta] CHECK CONSTRAINT [FK_consulta_turno]
GO
ALTER TABLE [dbo].[disponibilidad_profesional]  WITH CHECK ADD  CONSTRAINT [FK_disponibilidad_profesional_profesional] FOREIGN KEY([matricula])
REFERENCES [dbo].[profesional] ([matricula])
GO
ALTER TABLE [dbo].[disponibilidad_profesional] CHECK CONSTRAINT [FK_disponibilidad_profesional_profesional]
GO
ALTER TABLE [dbo].[historial_clinico]  WITH CHECK ADD  CONSTRAINT [FK_historial_clinico_consulta] FOREIGN KEY([id_consulta])
REFERENCES [dbo].[consulta] ([id_consulta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[historial_clinico] CHECK CONSTRAINT [FK_historial_clinico_consulta]
GO
ALTER TABLE [dbo].[historial_clinico]  WITH CHECK ADD  CONSTRAINT [FK_historial_clinico_paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[paciente] ([dni])
GO
ALTER TABLE [dbo].[historial_clinico] CHECK CONSTRAINT [FK_historial_clinico_paciente]
GO
ALTER TABLE [dbo].[historial_turnos]  WITH CHECK ADD  CONSTRAINT [FK_historial_turnos_paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[paciente] ([dni])
GO
ALTER TABLE [dbo].[historial_turnos] CHECK CONSTRAINT [FK_historial_turnos_paciente]
GO
ALTER TABLE [dbo].[historial_turnos]  WITH CHECK ADD  CONSTRAINT [FK_historial_turnos_profesional] FOREIGN KEY([id_profesional])
REFERENCES [dbo].[profesional] ([matricula])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[historial_turnos] CHECK CONSTRAINT [FK_historial_turnos_profesional]
GO
ALTER TABLE [dbo].[historial_turnos]  WITH CHECK ADD  CONSTRAINT [FK_historial_turnos_turno] FOREIGN KEY([num_turno])
REFERENCES [dbo].[turno] ([num_turno])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[historial_turnos] CHECK CONSTRAINT [FK_historial_turnos_turno]
GO
ALTER TABLE [dbo].[insumo_x_practica]  WITH CHECK ADD  CONSTRAINT [FK_insumo_x_practica_insumo] FOREIGN KEY([id_insumo])
REFERENCES [dbo].[insumo] ([id_insumo])
GO
ALTER TABLE [dbo].[insumo_x_practica] CHECK CONSTRAINT [FK_insumo_x_practica_insumo]
GO
ALTER TABLE [dbo].[insumo_x_practica]  WITH CHECK ADD  CONSTRAINT [FK_insumo_x_practica_practica] FOREIGN KEY([id_practica])
REFERENCES [dbo].[practica] ([id_practica])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[insumo_x_practica] CHECK CONSTRAINT [FK_insumo_x_practica_practica]
GO
ALTER TABLE [dbo].[pracXcons]  WITH CHECK ADD  CONSTRAINT [FK_practicas_x_consulta_consulta] FOREIGN KEY([id_consulta])
REFERENCES [dbo].[consulta] ([id_consulta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pracXcons] CHECK CONSTRAINT [FK_practicas_x_consulta_consulta]
GO
ALTER TABLE [dbo].[pracXcons]  WITH CHECK ADD  CONSTRAINT [FK_practicas_x_consulta_practica] FOREIGN KEY([id_practica])
REFERENCES [dbo].[practica] ([id_practica])
GO
ALTER TABLE [dbo].[pracXcons] CHECK CONSTRAINT [FK_practicas_x_consulta_practica]
GO
ALTER TABLE [dbo].[turno]  WITH CHECK ADD  CONSTRAINT [FK_turno_obra_social] FOREIGN KEY([id_obra_social])
REFERENCES [dbo].[obra_social] ([cod_obra_social])
GO
ALTER TABLE [dbo].[turno] CHECK CONSTRAINT [FK_turno_obra_social]
GO
ALTER TABLE [dbo].[turno]  WITH CHECK ADD  CONSTRAINT [FK_turno_paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[paciente] ([dni])
GO
ALTER TABLE [dbo].[turno] CHECK CONSTRAINT [FK_turno_paciente]
GO
ALTER TABLE [dbo].[turno]  WITH CHECK ADD  CONSTRAINT [FK_turno_profesional] FOREIGN KEY([id_profesional])
REFERENCES [dbo].[profesional] ([matricula])
GO
ALTER TABLE [dbo].[turno] CHECK CONSTRAINT [FK_turno_profesional]
GO

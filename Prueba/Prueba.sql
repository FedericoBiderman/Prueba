USE [Prueba]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 20/9/2023 09:43:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[IdAlumno] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Legajo] [varchar](50) NOT NULL,
	[Curso] [int] NOT NULL,
	[Edad] [int] NOT NULL,
	[Promedio] [int] NOT NULL,
	[Especialidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[IdAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Alumnos] ([IdAlumno], [Nombre], [Apellido], [Legajo], [Curso], [Edad], [Promedio], [Especialidad]) VALUES (1, N'Federico', N'Biderman', N'48038607', 4, 16, 8, N'Informatica')
INSERT [dbo].[Alumnos] ([IdAlumno], [Nombre], [Apellido], [Legajo], [Curso], [Edad], [Promedio], [Especialidad]) VALUES (2, N'Mateo', N'Cottet', N'47352556', 5, 17, 7, N'Quimica')
INSERT [dbo].[Alumnos] ([IdAlumno], [Nombre], [Apellido], [Legajo], [Curso], [Edad], [Promedio], [Especialidad]) VALUES (3, N'Uriel', N'Ragusa', N'46732329', 7, 19, 9, N'Construccion')
INSERT [dbo].[Alumnos] ([IdAlumno], [Nombre], [Apellido], [Legajo], [Curso], [Edad], [Promedio], [Especialidad]) VALUES (4, N'Matias', N'Szabo', N'47802314', 6, 18, 6, N'Mecatronica')
INSERT [dbo].[Alumnos] ([IdAlumno], [Nombre], [Apellido], [Legajo], [Curso], [Edad], [Promedio], [Especialidad]) VALUES (5, N'Franco', N'Esteves', N'48241425', 3, 15, 5, N'Gestion')
GO

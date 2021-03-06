USE [FilipMaleckiLab3]
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 11/22/2017 8:16:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](31) NOT NULL,
	[Surname] [nvarchar](31) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
 CONSTRAINT [PK_Actor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cast]    Script Date: 11/22/2017 8:16:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FilmId] [int] NOT NULL,
	[ActorId] [int] NOT NULL,
 CONSTRAINT [PK_Cast] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Film]    Script Date: 11/22/2017 8:16:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](63) NOT NULL,
	[ProductionYear] [smallint] NOT NULL,
	[Duration] [smallint] NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Actor] ON 

INSERT [dbo].[Actor] ([Id], [Name], [Surname], [DateOfBirth]) VALUES (1, N'Alan', N'Rickman', CAST(N'1990-01-23' AS Date))
INSERT [dbo].[Actor] ([Id], [Name], [Surname], [DateOfBirth]) VALUES (4, N'Tosia', N'Nawrocka', CAST(N'1990-12-12' AS Date))
INSERT [dbo].[Actor] ([Id], [Name], [Surname], [DateOfBirth]) VALUES (5, N'Andrzej', N'Piotrowski', CAST(N'1985-01-01' AS Date))
INSERT [dbo].[Actor] ([Id], [Name], [Surname], [DateOfBirth]) VALUES (6, N'Jas', N'Fasola', CAST(N'1969-06-06' AS Date))
INSERT [dbo].[Actor] ([Id], [Name], [Surname], [DateOfBirth]) VALUES (7, N'Jas', N'Fasola', CAST(N'1969-06-06' AS Date))
SET IDENTITY_INSERT [dbo].[Actor] OFF
SET IDENTITY_INSERT [dbo].[Cast] ON 

INSERT [dbo].[Cast] ([Id], [FilmId], [ActorId]) VALUES (1, 1, 1)
INSERT [dbo].[Cast] ([Id], [FilmId], [ActorId]) VALUES (2, 8, 3)
INSERT [dbo].[Cast] ([Id], [FilmId], [ActorId]) VALUES (3, 9, 2)
INSERT [dbo].[Cast] ([Id], [FilmId], [ActorId]) VALUES (4, 10, 3)
SET IDENTITY_INSERT [dbo].[Cast] OFF
SET IDENTITY_INSERT [dbo].[Film] ON 

INSERT [dbo].[Film] ([Id], [Name], [ProductionYear], [Duration]) VALUES (1, N'Harry Potter', 2010, 190)
INSERT [dbo].[Film] ([Id], [Name], [ProductionYear], [Duration]) VALUES (8, N'Avatar', 2012, 180)
INSERT [dbo].[Film] ([Id], [Name], [ProductionYear], [Duration]) VALUES (9, N'Star Wars', 2000, 200)
INSERT [dbo].[Film] ([Id], [Name], [ProductionYear], [Duration]) VALUES (10, N'Kiler', 1998, 100)
SET IDENTITY_INSERT [dbo].[Film] OFF

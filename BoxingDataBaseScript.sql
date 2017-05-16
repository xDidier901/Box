USE [master]
GO
/****** Object:  Database [BoxManagerDB]    Script Date: 15-May-17 8:02:58 PM ******/
CREATE DATABASE [BoxManagerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BoxManagerDB', FILENAME = N'C:\Users\Didier Valdez\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\BoxManagerDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BoxManagerDB_log', FILENAME = N'C:\Users\Didier Valdez\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\BoxManagerDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BoxManagerDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BoxManagerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BoxManagerDB] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [BoxManagerDB] SET ANSI_NULLS ON 
GO
ALTER DATABASE [BoxManagerDB] SET ANSI_PADDING ON 
GO
ALTER DATABASE [BoxManagerDB] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [BoxManagerDB] SET ARITHABORT ON 
GO
ALTER DATABASE [BoxManagerDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BoxManagerDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BoxManagerDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BoxManagerDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BoxManagerDB] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [BoxManagerDB] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [BoxManagerDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BoxManagerDB] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [BoxManagerDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BoxManagerDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BoxManagerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BoxManagerDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BoxManagerDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BoxManagerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BoxManagerDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BoxManagerDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BoxManagerDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BoxManagerDB] SET RECOVERY FULL 
GO
ALTER DATABASE [BoxManagerDB] SET  MULTI_USER 
GO
ALTER DATABASE [BoxManagerDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BoxManagerDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BoxManagerDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BoxManagerDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BoxManagerDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BoxManagerDB] SET QUERY_STORE = OFF
GO
USE [BoxManagerDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BoxManagerDB]
GO
/****** Object:  Table [dbo].[Acciones]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acciones](
	[Id_Accion] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](80) NOT NULL,
	[Fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Accion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Boxeadores]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boxeadores](
	[Id_Boxeador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](80) NOT NULL,
	[Rama] [nchar](10) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Categoria] [int] NOT NULL,
	[Division] [int] NOT NULL,
	[Municipio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Boxeador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](80) NOT NULL,
	[Rama] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Divisiones]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divisiones](
	[Id_Division] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](80) NOT NULL,
	[Categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Division] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipios]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipios](
	[Id_Municipio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Municipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registros]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registros](
	[Id_Registro] [int] IDENTITY(1,1) NOT NULL,
	[Registro] [nchar](80) NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Acciones] ON 

INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (1, N'Se agregó al boxeador Jorge Leon en la base de datos                            ', CAST(N'2017-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2, N'Se modificó al boxeador Jorge Fernandez en la base de datos                     ', CAST(N'2017-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (3, N'Se eliminó al boxeador Jorge Fernandez de la base de datos                      ', CAST(N'2017-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (1002, N'Se agregó al boxeador Hector Flores en la base de datos                         ', CAST(N'2017-05-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2002, N'Se agregó la división SuperWelter en la base de datos                           ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2003, N'Se agregó la división Pesado en la base de datos                                ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2004, N'Se modificó la categoría 17 - 18 años (1999 - 2000) F en la base de datos       ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2005, N'Se modificó la categoría 17 - 18 años F (1999 - 2000) en la base de datos       ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2006, N'Se agregó al boxeador Jesus Maximo en la base de datos                          ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2007, N'Se agregó al boxeador Melisa Torres en la base de datos                         ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2008, N'Se agregó la división SuperDuperMosca en la base de datos                       ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2009, N'Se agregó la división SuperDuperWelter en la base de datos                      ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2010, N'Se agregó al boxeador juan perez en la base de datos                            ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2011, N'Se modificó al boxeador Didier Valdez en la base de datos                       ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2012, N'Se eliminó al boxeador juan perez de la base de datos                           ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2013, N'Se eliminó la división Plulma de la base de datos                               ', CAST(N'2017-05-08T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Acciones] OFF
SET IDENTITY_INSERT [dbo].[Boxeadores] ON 

INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (1, N'Didier Valdez                                                                   ', N'Varonil   ', CAST(N'1999-06-13T00:00:00.000' AS DateTime), 3, 9, 3)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (2, N'Luis Medina                                                                     ', N'Varonil   ', CAST(N'2001-12-15T00:00:00.000' AS DateTime), 2, 3, 2)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (3, N'Karina Ulloa                                                                    ', N'Femenil   ', CAST(N'2001-11-11T00:00:00.000' AS DateTime), 4, 3, 4)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (1002, N'Hector Flores                                                                   ', N'Varonil   ', CAST(N'2010-12-25T00:00:00.000' AS DateTime), 2, 7, 6)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (2002, N'Jesus Maximo                                                                    ', N'Varonil   ', CAST(N'1999-08-12T00:00:00.000' AS DateTime), 3, 14, 2)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (2003, N'Melisa Torres                                                                   ', N'Femenil   ', CAST(N'1999-04-17T00:00:00.000' AS DateTime), 4, 17, 5)
SET IDENTITY_INSERT [dbo].[Boxeadores] OFF
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([Id_Categoria], [Nombre], [Rama]) VALUES (2, N'15 - 16 años (2001 - 2002)                                                      ', N'Varonil   ')
INSERT [dbo].[Categorias] ([Id_Categoria], [Nombre], [Rama]) VALUES (3, N'17 - 18 años (1999 - 2000)                                                      ', N'Varonil   ')
INSERT [dbo].[Categorias] ([Id_Categoria], [Nombre], [Rama]) VALUES (4, N'17 - 18 años F (1999 - 2000)                                                    ', N'Femenil   ')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
SET IDENTITY_INSERT [dbo].[Divisiones] ON 

INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (1, N'Mosca                                                                           ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (2, N'Supermosca                                                                      ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (3, N'Gallo                                                                           ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (4, N'Supergallos                                                                     ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (5, N'Pluma                                                                           ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (6, N'Ligero                                                                          ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (7, N'Welter                                                                          ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (8, N'Mosca                                                                           ', 3)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (9, N'Supermosca                                                                      ', 3)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (10, N'Gallo                                                                           ', 3)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (11, N'Supergallos                                                                     ', 3)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (12, N'Pluma                                                                           ', 3)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (13, N'Ligero                                                                          ', 3)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (14, N'Welter                                                                          ', 3)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (15, N'Minimosca                                                                       ', 4)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (16, N'Mosca                                                                           ', 4)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (17, N'Minigallos                                                                      ', 4)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (18, N'Gallo                                                                           ', 4)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (19, N'Supergallos                                                                     ', 4)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (1002, N'SuperWelter                                                                     ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (1003, N'Pesado                                                                          ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (1004, N'SuperDuperMosca                                                                 ', 4)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (1005, N'SuperDuperWelter                                                                ', 3)
SET IDENTITY_INSERT [dbo].[Divisiones] OFF
SET IDENTITY_INSERT [dbo].[Municipios] ON 

INSERT [dbo].[Municipios] ([Id_Municipio], [Nombre]) VALUES (1, N'Hermosillo                                                                                          ')
INSERT [dbo].[Municipios] ([Id_Municipio], [Nombre]) VALUES (2, N'Agua Prieta                                                                                         ')
INSERT [dbo].[Municipios] ([Id_Municipio], [Nombre]) VALUES (3, N'Cajeme                                                                                              ')
INSERT [dbo].[Municipios] ([Id_Municipio], [Nombre]) VALUES (4, N'Nogales                                                                                             ')
INSERT [dbo].[Municipios] ([Id_Municipio], [Nombre]) VALUES (5, N'Guaymas                                                                                             ')
INSERT [dbo].[Municipios] ([Id_Municipio], [Nombre]) VALUES (6, N'Empalme                                                                                             ')
INSERT [dbo].[Municipios] ([Id_Municipio], [Nombre]) VALUES (7, N'Navojoa                                                                                             ')
INSERT [dbo].[Municipios] ([Id_Municipio], [Nombre]) VALUES (8, N'Huatabampo                                                                                          ')
SET IDENTITY_INSERT [dbo].[Municipios] OFF
/****** Object:  StoredProcedure [dbo].[accionesPor2Fechas]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[accionesPor2Fechas]
	@fechaInicial datetime,
	@fechaFinal datetime
AS
	SELECT Acciones.Descripcion as Descripción, Acciones.Fecha as Fecha from Acciones
	where Acciones.Fecha between @fechaInicial and @fechaFinal order by Acciones.Id_Accion desc
GO
/****** Object:  StoredProcedure [dbo].[reporteBoxeadores]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteBoxeadores]
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
		order by Boxeadores.Nombre desc
GO
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorCategoria]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteBoxeadoresPorCategoria]
	@categoria int
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where	 (Boxeadores.Categoria = @categoria)
	order by Boxeadores.Nombre desc
GO
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorCategoriaDivision]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteBoxeadoresPorCategoriaDivision]
	@categoria int,
	@division int
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where(Boxeadores.Categoria = @categoria) and  
	 (Boxeadores.Division = @division)
	order by Boxeadores.Nombre desc
GO
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorCategoriaDivisionMunicipio]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteBoxeadoresPorCategoriaDivisionMunicipio]
	@categoria int,
	@division int,
	@municipio int
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where (Boxeadores.Categoria = @categoria) and  
	 (Boxeadores.Division = @division)   and 
	 (Boxeadores.Municipio = @municipio)
	order by Boxeadores.Nombre desc
GO
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorCategoriaMunicipio]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteBoxeadoresPorCategoriaMunicipio]
	@categoria int,
	@municipio int
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where (Boxeadores.Categoria = @categoria) and
	 (Boxeadores.Municipio = @municipio)
	order by Boxeadores.Nombre desc
GO
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorMunicipio]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteBoxeadoresPorMunicipio]
	@municipio int
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where(Boxeadores.Municipio = @municipio)
	order by Boxeadores.Nombre desc
GO
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorRama]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteBoxeadoresPorRama]
	@Rama varchar(10)
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where (Boxeadores.Rama = @rama)
	order by Boxeadores.Nombre desc
GO
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorRamaMunicipio]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteBoxeadoresPorRamaMunicipio]
	@Rama varchar(10),
	@municipio int
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where (Boxeadores.Rama = @rama) and
	 (Boxeadores.Municipio = @municipio)
	order by Boxeadores.Nombre desc
GO
/****** Object:  StoredProcedure [dbo].[ReporteGrafica]    Script Date: 15-May-17 8:02:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteGrafica]
AS
Select Categorias.Nombre as Categoria,
(SELECT COUNT(Divisiones.Nombre) from Divisiones where Categorias.Id_Categoria = Divisiones.Categoria) as Divisiones
 from Categorias
GO
USE [master]
GO
ALTER DATABASE [BoxManagerDB] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [BoxManagerDB]    Script Date: 23/01/2018 08:37:37 p. m. ******/
CREATE DATABASE [BoxManagerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BoxManagerDB', FILENAME = N'C:\Users\Didier\Documents\BoxDatabase\BoxManagerDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BoxManagerDB_log', FILENAME = N'C:\Users\Didier\Documents\BoxDatabase\BoxManagerDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
ALTER DATABASE [BoxManagerDB] SET AUTO_CREATE_STATISTICS ON 
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
USE [BoxManagerDB]
GO
/****** Object:  StoredProcedure [dbo].[accionesPor2Fechas]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reporteBoxeadores]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorCategoria]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorCategoriaDivision]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorCategoriaDivisionMunicipio]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorCategoriaMunicipio]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorMunicipio]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorRama]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reporteBoxeadoresPorRamaMunicipio]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[ReporteGrafica]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[reportePeleasPorTorneoID]    Script Date: 23/01/2018 08:37:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reportePeleasPorTorneoID]
	@torneo int
AS
	SELECT Pelea.Id_Boxeador1 as Boxeador_1, Pelea.Id_Boxeador2 as Boxeador_2, Pelea.Etapa, Pelea.Ganador,Pelea.Fecha from Pelea
	where	 (Pelea.Id_Torneo= @torneo)
	order by Pelea.Etapa desc
GO
/****** Object:  Table [dbo].[Acciones]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  Table [dbo].[Boxeadores]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  Table [dbo].[Categorias]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  Table [dbo].[Divisiones]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  Table [dbo].[Municipios]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  Table [dbo].[Pelea]    Script Date: 23/01/2018 08:37:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelea](
	[Id_Pelea] [int] IDENTITY(1,1) NOT NULL,
	[Id_Boxeador1] [nchar](80) NOT NULL,
	[Id_Boxeador2] [nchar](80) NOT NULL,
	[Id_Torneo] [int] NOT NULL,
	[Etapa] [int] NOT NULL,
	[Ganador] [nchar](80) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pelea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registros]    Script Date: 23/01/2018 08:37:37 p. m. ******/
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
/****** Object:  Table [dbo].[Torneo]    Script Date: 23/01/2018 08:37:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Torneo](
	[Id_Torneo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](30) NOT NULL,
	[Id_Categoria] [int] NOT NULL,
	[Rama] [nchar](10) NOT NULL,
	[NumParticipantes] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Torneo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Acciones] ON 

INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (1, N'Se agregó al boxeador Jorge Leon en la base de datos                            ', CAST(0x0000A76800000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2, N'Se modificó al boxeador Jorge Fernandez en la base de datos                     ', CAST(0x0000A76800000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (3, N'Se eliminó al boxeador Jorge Fernandez de la base de datos                      ', CAST(0x0000A76800000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (1002, N'Se agregó al boxeador Hector Flores en la base de datos                         ', CAST(0x0000A76900000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2002, N'Se agregó la división SuperWelter en la base de datos                           ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2003, N'Se agregó la división Pesado en la base de datos                                ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2004, N'Se modificó la categoría 17 - 18 años (1999 - 2000) F en la base de datos       ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2005, N'Se modificó la categoría 17 - 18 años F (1999 - 2000) en la base de datos       ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2006, N'Se agregó al boxeador Jesus Maximo en la base de datos                          ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2007, N'Se agregó al boxeador Melisa Torres en la base de datos                         ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2008, N'Se agregó la división SuperDuperMosca en la base de datos                       ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2009, N'Se agregó la división SuperDuperWelter en la base de datos                      ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2010, N'Se agregó al boxeador juan perez en la base de datos                            ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2011, N'Se modificó al boxeador Didier en la base de datos                              ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2012, N'Se eliminó al boxeador juan perez de la base de datos                           ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (2013, N'Se eliminó la división Plulma de la base de datos                               ', CAST(0x0000A76D00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (3002, N'Se agregó al boxeador Julián Gamboa en la base de datos                         ', CAST(0x0000A80A00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (3003, N'Se agregó al boxeador Rubén Locosa en la base de datos                          ', CAST(0x0000A80A00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (4002, N'Se creó el torneo TorneoPrueba en la base de datos                              ', CAST(0x0000A85F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (4003, N'Se creó el torneo TorneoEstatalUno en la base de datos                          ', CAST(0x0000A85F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (4004, N'Se creó el torneo Torneo Estatal 2017 en la base de datos                       ', CAST(0x0000A85F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (4005, N'Se creó el torneo PruebaRandom en la base de datos                              ', CAST(0x0000A85F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5002, N'Se creó el torneo Torneo Test en la base de datos                               ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5003, N'Se registró la pelea: 1 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5004, N'Se registró la pelea: 2 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5005, N'Se creó el torneo TorneoTest2 en la base de datos                               ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5006, N'Se registró la pelea: 3 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5007, N'Se registró la pelea: 4 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5008, N'Se registró la pelea: 5 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5009, N'Se creó el torneo Test3 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5010, N'Se registró la pelea: 6 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5011, N'Se registró la pelea: 7 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5012, N'Se registró la pelea: 8 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5013, N'Se creó el torneo Test4 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5014, N'Se registró la pelea: 9 en la base de datos                                     ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5015, N'Se registró la pelea: 10 en la base de datos                                    ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (5016, N'Se registró la pelea: 11 en la base de datos                                    ', CAST(0x0000A86300000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (6002, N'Se creó el torneo fgdfg en la base de datos                                     ', CAST(0x0000A86A00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (6003, N'Se registró la pelea: 1002 en la base de datos                                  ', CAST(0x0000A86A00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (6004, N'Se registró la pelea: 1003 en la base de datos                                  ', CAST(0x0000A86A00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (6005, N'Se registró la pelea: 1004 en la base de datos                                  ', CAST(0x0000A86A00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (7002, N'Se creó el torneo TestPeleasPRO en la base de datos                             ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (7003, N'Se registró la pelea: 2002 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (7004, N'Se registró la pelea: 2003 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (7005, N'Se registró la pelea: 2004 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (8002, N'Se creó el torneo testprogressbar en la base de datos                           ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (8003, N'Se registró la pelea: 3002 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (8004, N'Se registró la pelea: 3003 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (8005, N'Se registró la pelea: 3004 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (8006, N'Se creó el torneo test24234234 en la base de datos                              ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (8007, N'Se registró la pelea: 3005 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (8008, N'Se registró la pelea: 3006 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (8009, N'Se registró la pelea: 3007 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9002, N'Se creó el torneo test123124 en la base de datos                                ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9003, N'Se registró la pelea: 4002 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9004, N'Se registró la pelea: 4003 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9005, N'Se registró la pelea: 4004 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9006, N'Se creó el torneo test en la base de datos                                      ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9007, N'Se registró la pelea: 4005 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9008, N'Se registró la pelea: 4006 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9009, N'Se registró la pelea: 4007 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9010, N'Se creó el torneo test en la base de datos                                      ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9011, N'Se registró la pelea: 4008 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9012, N'Se registró la pelea: 4009 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9013, N'Se creó el torneo test en la base de datos                                      ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9014, N'Se registró la pelea: 4010 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9015, N'Se registró la pelea: 4011 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9016, N'Se creó el torneo test en la base de datos                                      ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9017, N'Se registró la pelea: 4012 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9018, N'Se registró la pelea: 4013 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9019, N'Se registró la pelea: 4014 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9020, N'Se creó el torneo test234234 en la base de datos                                ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9021, N'Se registró la pelea: 4015 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9022, N'Se registró la pelea: 4016 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9023, N'Se registró la pelea: 4017 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9024, N'Se creó el torneo test23423 en la base de datos                                 ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9025, N'Se registró la pelea: 4018 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9026, N'Se registró la pelea: 4019 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9027, N'Se creó el torneo test en la base de datos                                      ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9028, N'Se registró la pelea: 4020 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9029, N'Se registró la pelea: 4021 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9030, N'Se creó el torneo test en la base de datos                                      ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9031, N'Se registró la pelea: 4022 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9032, N'Se registró la pelea: 4023 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9033, N'Se creó el torneo test214235345636 en la base de datos                          ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9034, N'Se registró la pelea: 4024 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (9035, N'Se registró la pelea: 4025 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (10033, N'Se creó el torneo TestTorneoPRO5000 en la base de datos                         ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (10034, N'Se registró la pelea: 5024 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (10035, N'Se registró la pelea: 5025 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (10036, N'Se registró la pelea: 5026 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (10037, N'Se creó el torneo TestTorneo en la base de datos                                ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (10038, N'Se registró la pelea: 5027 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (10039, N'Se registró la pelea: 5028 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (10040, N'Se registró la pelea: 5029 en la base de datos                                  ', CAST(0x0000A86C00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11033, N'Se agregó al boxeador Boxeador12 en la base de datos                            ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11034, N'Se agregó al boxeador JuanitoTest en la base de datos                           ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11035, N'Se agregó al boxeador José Luis en la base de datos                             ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11036, N'Se agregó al boxeador Juan Ibarra en la base de datos                           ', CAST(0x0000A86F00000000 AS DateTime))
GO
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11037, N'Se agregó al boxeador Pepe Perez en la base de datos                            ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11038, N'Se creó el torneo TorneoPrueba en la base de datos                              ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11039, N'Se registró la pelea: 6024 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11040, N'Se registró la pelea: 6025 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11041, N'Se registró la pelea: 6026 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11042, N'Se registró la pelea: 6027 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (11043, N'Se registró la pelea: 6028 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12033, N'Se creó el torneo TorneoPrueba2 en la base de datos                             ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12034, N'Se registró la pelea: 7024 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12035, N'Se registró la pelea: 7025 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12036, N'Se registró la pelea: 7026 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12037, N'Se registró la pelea: 7027 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12038, N'Se registró la pelea: 7028 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12039, N'Se creó el torneo TorneoPrueba3 en la base de datos                             ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12040, N'Se registró la pelea: 7029 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12041, N'Se registró la pelea: 7030 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12042, N'Se registró la pelea: 7031 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12043, N'Se registró la pelea: 7032 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (12044, N'Se registró la pelea: 7033 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13033, N'Se eliminó el torneo 5004 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13034, N'Se eliminó el torneo 5006 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13035, N'Se eliminó el torneo 5005 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13036, N'Se eliminó el torneo 5003 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13037, N'Se eliminó el torneo 3002 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13038, N'Se eliminó el torneo 5003 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13039, N'Se eliminó el torneo 5010 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13040, N'Se eliminó el torneo 5009 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13041, N'Se eliminó el torneo 2002 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13042, N'Se eliminó el torneo 5011 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13043, N'Se eliminó el torneo 5012 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13044, N'Se eliminó el torneo 1002 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13045, N'Se eliminó el torneo 1005 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13046, N'Se eliminó el torneo 5008 de la base de datos                                   ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13047, N'Se creó el torneo TorneoPrueba4 en la base de datos                             ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13048, N'Se registró la pelea: 8024 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13049, N'Se registró la pelea: 8025 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13050, N'Se registró la pelea: 8026 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13051, N'Se registró la pelea: 8027 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13052, N'Se registró la pelea: 8028 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13053, N'Se creó el torneo TorneoPruebas5 en la base de datos                            ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13054, N'Se registró la pelea: 8029 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13055, N'Se registró la pelea: 8030 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13056, N'Se registró la pelea: 8031 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13057, N'Se registró la pelea: 8032 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13058, N'Se registró la pelea: 8033 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13059, N'Se creó el torneo TorneoPrueba6 en la base de datos                             ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13060, N'Se registró la pelea: 8034 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13061, N'Se registró la pelea: 8035 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13062, N'Se registró la pelea: 8036 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13063, N'Se registró la pelea: 8037 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (13064, N'Se registró la pelea: 8038 en la base de datos                                  ', CAST(0x0000A86F00000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14033, N'Se eliminó el torneo 8013 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14034, N'Se eliminó el torneo 8012 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14035, N'Se eliminó el torneo 7013 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14036, N'Se eliminó el torneo 7012 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14037, N'Se eliminó el torneo 6012 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14038, N'Se eliminó el torneo 5013 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14039, N'Se eliminó el torneo 5007 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14040, N'Se eliminó el torneo 5002 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14041, N'Se eliminó el torneo 4003 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14042, N'Se eliminó el torneo 4002 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14043, N'Se eliminó el torneo 1003 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14044, N'Se eliminó el torneo 1004 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14045, N'Se creó el torneo TorneoPrueba7 en la base de datos                             ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14046, N'Se registró la pelea: 9024 en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14047, N'Se registró la pelea: 9025 en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14048, N'Se registró la pelea: 9026 en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14049, N'Se registró la pelea: 9027 en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14050, N'Se creó el torneo Torneo Pruebas 8 en la base de datos                          ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14051, N'Se registró la pelea: 9028 en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14052, N'Se registró la pelea: 9029 en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14053, N'Se registró la pelea: 9030 en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (14054, N'Se registró la pelea: 9031 en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15033, N'Se actualizó la pelea: 9028 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15034, N'Se actualizó la pelea: 9030 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15035, N'Se actualizó la pelea: 9031 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15036, N'Se actualizó la pelea: 8034 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15037, N'Se actualizó la pelea: 8035 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15038, N'Se actualizó la pelea: 8036 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15039, N'Se actualizó la pelea: 8038 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15040, N'Se eliminó la división Supermosca de la base de datos                           ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15041, N'Se eliminó la división Supermosca de la base de datos                           ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15042, N'Se eliminó la división Supergallos de la base de datos                          ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15043, N'Se modificó al boxeador BoxeadorTest1 en la base de datos                       ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15044, N'Se actualizó la pelea: 9024 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15045, N'Se actualizó la pelea: 9025 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15046, N'Se actualizó la pelea: 9026 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15047, N'Se actualizó la pelea: 9027 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15048, N'Se creó el torneo TestPrueba9 en la base de datos                               ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15049, N'Se registró la pelea: 10024 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15050, N'Se registró la pelea: 10025 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15051, N'Se registró la pelea: 10026 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15052, N'Se registró la pelea: 10027 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15053, N'Se actualizó la pelea: 10026 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15054, N'Se actualizó la pelea: 10027 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15055, N'Se actualizó la pelea: 10025 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15056, N'Se actualizó la pelea: 10026 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (15057, N'Se actualizó la pelea: 10027 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16033, N'Se registró la pelea: 11024 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16034, N'Se registró la pelea: 11025 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
GO
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16035, N'Se registró la pelea: 11026 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16036, N'Se eliminó el torneo 8014 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16037, N'Se creó el torneo TorneoTet en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16038, N'Se registró la pelea: 11027 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16039, N'Se registró la pelea: 11028 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16040, N'Se registró la pelea: 11029 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16041, N'Se registró la pelea: 11030 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16042, N'Se registró la pelea: 11031 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16043, N'Se actualizó la pelea: 11027 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16044, N'Se actualizó la pelea: 11028 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16045, N'Se actualizó la pelea: 11029 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16046, N'Se actualizó la pelea: 11030 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16047, N'Se registró la pelea: 11032 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16048, N'Se registró la pelea: 11033 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16049, N'Se registró la pelea: 11034 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16050, N'Se actualizó la pelea: 11032 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16051, N'Se actualizó la pelea: 11034 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16052, N'Se actualizó la pelea: 11027 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16053, N'Se actualizó la pelea: 11028 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16054, N'Se actualizó la pelea: 11029 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16055, N'Se actualizó la pelea: 11030 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16056, N'Se registró la pelea: 11035 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16057, N'Se registró la pelea: 11036 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16058, N'Se registró la pelea: 11037 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16059, N'Se registró la pelea: 11038 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16060, N'Se eliminó el torneo 11012 de la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16061, N'Se registró la pelea: 11039 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16062, N'Se registró la pelea: 11040 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16063, N'Se actualizó la pelea: 11039 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16064, N'Se actualizó la pelea: 11040 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16065, N'Se registró la pelea: 11041 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (16066, N'Se actualizó la pelea: 11041 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (17033, N'Se registró la pelea: 12024 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (17034, N'Se registró la pelea: 12025 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (17035, N'Se actualizó la pelea: 12025 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (17036, N'Se actualizó la pelea: 12024 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (17037, N'Se actualizó la pelea: 12025 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (18033, N'Se registró la pelea: 13024 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (18034, N'Se registró la pelea: 13025 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (18035, N'Se actualizó la pelea: 13024 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (18036, N'Se actualizó la pelea: 13025 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (18037, N'Se registró la pelea: 13026 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (18038, N'Se actualizó la pelea: 13026 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (18039, N'Se registró la pelea: 13027 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (18040, N'Se actualizó la pelea: 13027 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19033, N'Se eliminó el torneo 9013 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19034, N'Se eliminó el torneo 9012 de la base de datos                                   ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19035, N'Se eliminó el torneo 10012 de la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19036, N'Se creó el torneo TorneoPrueba1 en la base de datos                             ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19037, N'Se registró la pelea: 14024 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19038, N'Se registró la pelea: 14025 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19039, N'Se registró la pelea: 14026 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19040, N'Se registró la pelea: 14027 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19041, N'Se creó el torneo TorneoPrueba2 en la base de datos                             ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19042, N'Se registró la pelea: 14028 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19043, N'Se registró la pelea: 14029 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19044, N'Se registró la pelea: 14030 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19045, N'Se registró la pelea: 14031 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19046, N'Se agregó al boxeador Karina Ulloa en la base de datos                          ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19047, N'Se modificó al boxeador pollo en la base de datos                               ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19048, N'Se eliminó al boxeador pollo de la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19049, N'Se creó el torneo Peleitas en la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19050, N'Se registró la pelea: 14032 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19051, N'Se registró la pelea: 14033 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19052, N'Se actualizó la pelea: 14032 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19053, N'Se actualizó la pelea: 14032 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19054, N'Se actualizó la pelea: 14032 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19055, N'Se actualizó la pelea: 14033 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19056, N'Se registró la pelea: 14034 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19057, N'Se actualizó la pelea: 14034 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19058, N'Se eliminó el torneo 12014 de la base de datos                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19059, N'Se actualizó la pelea: 14026 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19060, N'Se actualizó la pelea: 14026 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19061, N'Se actualizó la pelea: 14026 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19062, N'Se actualizó la pelea: 14024 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19063, N'Se actualizó la pelea: 14026 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19064, N'Se actualizó la pelea: 14024 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19065, N'Se actualizó la pelea: 14026 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19066, N'Se actualizó la pelea: 14027 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19067, N'Se registró la pelea: 14035 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19068, N'Se registró la pelea: 14036 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19069, N'Se actualizó la pelea: 14036 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19070, N'Se actualizó la pelea: 14036 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19071, N'Se actualizó la pelea: 14028 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19072, N'Se actualizó la pelea: 14030 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19073, N'Se actualizó la pelea: 14028 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19074, N'Se actualizó la pelea: 14029 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19075, N'Se actualizó la pelea: 14030 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19076, N'Se actualizó la pelea: 14031 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19077, N'Se registró la pelea: 14037 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19078, N'Se registró la pelea: 14038 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19079, N'Se actualizó la pelea: 14038 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19080, N'Se actualizó la pelea: 14038 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19081, N'Se actualizó la pelea: 14038 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19082, N'Se actualizó la pelea: 14038 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19083, N'Se actualizó la pelea: 14036 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19084, N'Se actualizó la pelea: 14035 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19085, N'Se registró la pelea: 14039 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19086, N'Se actualizó la pelea: 14037 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19087, N'Se registró la pelea: 14040 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
GO
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19088, N'Se actualizó la pelea: 14040 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19089, N'Se actualizó la pelea: 14039 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19090, N'Se creó el torneo TestTorneou en la base de datos                               ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19091, N'Se registró la pelea: 14041 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19092, N'Se registró la pelea: 14042 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19093, N'Se registró la pelea: 14043 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19094, N'Se registró la pelea: 14044 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19095, N'Se registró la pelea: 14045 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19096, N'Se actualizó la pelea: 14041 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19097, N'Se actualizó la pelea: 14044 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19098, N'Se actualizó la pelea: 14045 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19099, N'Se actualizó la pelea: 14043 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19100, N'Se actualizó la pelea: 14042 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19101, N'Se registró la pelea: 14046 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19102, N'Se registró la pelea: 14047 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19103, N'Se registró la pelea: 14048 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19104, N'Se actualizó la pelea: 14047 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19105, N'Se actualizó la pelea: 14048 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19106, N'Se registró la pelea: 14049 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19107, N'Se registró la pelea: 14050 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19108, N'Se actualizó la pelea: 14050 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19109, N'Se registró la pelea: 14051 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (19110, N'Se actualizó la pelea: 14051 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20033, N'Se creó el torneo Test en la base de datos                                      ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20034, N'Se registró la pelea: 14052 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20035, N'Se registró la pelea: 14053 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20036, N'Se registró la pelea: 14054 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20037, N'Se registró la pelea: 14055 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20038, N'Se registró la pelea: 14056 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20039, N'Se actualizó la pelea: 14052 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20040, N'Se actualizó la pelea: 14053 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20041, N'Se actualizó la pelea: 14054 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20042, N'Se actualizó la pelea: 14055 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20043, N'Se registró la pelea: 14057 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20044, N'Se registró la pelea: 14058 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20045, N'Se registró la pelea: 14059 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20046, N'Se actualizó la pelea: 14057 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20047, N'Se actualizó la pelea: 14059 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20048, N'Se registró la pelea: 14060 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20049, N'Se registró la pelea: 14061 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20050, N'Se actualizó la pelea: 14060 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20051, N'Se registró la pelea: 14062 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20052, N'Se actualizó la pelea: 14062 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20053, N'Se creó el torneo TestEquis en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20054, N'Se registró la pelea: 14063 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20055, N'Se registró la pelea: 14064 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20056, N'Se registró la pelea: 14065 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20057, N'Se registró la pelea: 14066 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20058, N'Se registró la pelea: 14067 en la base de datos                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20059, N'Se actualizó la pelea: 14063 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20060, N'Se actualizó la pelea: 14066 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20061, N'Se actualizó la pelea: 14064 en la base de datos                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Acciones] ([Id_Accion], [Descripcion], [Fecha]) VALUES (20062, N'Se actualizó la pelea: 14065 en la base de datos                                ', CAST(0x0000A87100000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Acciones] OFF
SET IDENTITY_INSERT [dbo].[Boxeadores] ON 

INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (1, N'Didier                                                                          ', N'Varonil   ', CAST(0x00008DE200000000 AS DateTime), 3, 9, 3)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (2, N'Luis Medina                                                                     ', N'Varonil   ', CAST(0x0000917600000000 AS DateTime), 2, 3, 2)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (1002, N'Hector Flores                                                                   ', N'Varonil   ', CAST(0x00009E5700000000 AS DateTime), 2, 7, 6)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (2002, N'Jesus Maximo                                                                    ', N'Varonil   ', CAST(0x00008E1E00000000 AS DateTime), 3, 14, 2)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (2003, N'Melisa Torres                                                                   ', N'Femenil   ', CAST(0x00008DA900000000 AS DateTime), 4, 17, 5)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (3002, N'Julián Gamboa                                                                   ', N'Varonil   ', CAST(0x00008E0200000000 AS DateTime), 3, 10, 5)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (3003, N'Rubén Locosa                                                                    ', N'Varonil   ', CAST(0x00008ECB00000000 AS DateTime), 3, 11, 4)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (4005, N'TestBoxeador                                                                    ', N'Varonil   ', CAST(0x00008ECB00000000 AS DateTime), 2, 7, 2)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (4006, N'BoxeadorTest1                                                                   ', N'Varonil   ', CAST(0x00008ECB00000000 AS DateTime), 2, 1, 3)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (4007, N'BoxeadorTest2                                                                   ', N'Varonil   ', CAST(0x00008ECB00000000 AS DateTime), 2, 7, 8)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (4008, N'BoxeadorTest3                                                                   ', N'Varonil   ', CAST(0x00008ECB00000000 AS DateTime), 2, 7, 3)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (4009, N'BoxeadorTest4                                                                   ', N'Varonil   ', CAST(0x00008ECB00000000 AS DateTime), 2, 7, 4)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (5002, N'Boxeador12                                                                      ', N'Varonil   ', CAST(0x0000807A00000000 AS DateTime), 2, 7, 7)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (5003, N'JuanitoTest                                                                     ', N'Varonil   ', CAST(0x0000806800000000 AS DateTime), 2, 7, 5)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (5004, N'José Luis                                                                       ', N'Varonil   ', CAST(0x0000806800000000 AS DateTime), 2, 7, 7)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (5005, N'Juan Ibarra                                                                     ', N'Varonil   ', CAST(0x0000807100000000 AS DateTime), 2, 6, 4)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (5006, N'Pepe Perez                                                                      ', N'Varonil   ', CAST(0x0000806800000000 AS DateTime), 2, 7, 1)
INSERT [dbo].[Boxeadores] ([Id_Boxeador], [Nombre], [Rama], [FechaNacimiento], [Categoria], [Division], [Municipio]) VALUES (6002, N'Karina Ulloa                                                                    ', N'Femenil   ', CAST(0x0000806A00000000 AS DateTime), 4, 16, 3)
SET IDENTITY_INSERT [dbo].[Boxeadores] OFF
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([Id_Categoria], [Nombre], [Rama]) VALUES (2, N'15 - 16 años (2001 - 2002)                                                      ', N'Varonil   ')
INSERT [dbo].[Categorias] ([Id_Categoria], [Nombre], [Rama]) VALUES (3, N'17 - 18 años (1999 - 2000)                                                      ', N'Varonil   ')
INSERT [dbo].[Categorias] ([Id_Categoria], [Nombre], [Rama]) VALUES (4, N'17 - 18 años F (1999 - 2000)                                                    ', N'Femenil   ')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
SET IDENTITY_INSERT [dbo].[Divisiones] ON 

INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (1, N'Mosca                                                                           ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (3, N'Gallo                                                                           ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (4, N'Supergallos                                                                     ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (5, N'Pluma                                                                           ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (6, N'Ligero                                                                          ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (7, N'Welter                                                                          ', 2)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (8, N'Mosca                                                                           ', 3)
INSERT [dbo].[Divisiones] ([Id_Division], [Nombre], [Categoria]) VALUES (10, N'Gallo                                                                           ', 3)
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
SET IDENTITY_INSERT [dbo].[Pelea] ON 

INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14052, N'4007-BoxeadorTest2                                                              ', N'4006-BoxeadorTest1                                                              ', 13012, 0, N'4006-BoxeadorTest1                                                              ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14053, N'5004-José Luis                                                                  ', N'1002-Hector Flores                                                              ', 13012, 0, N'5004-José Luis                                                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14054, N'4008-BoxeadorTest3                                                              ', N'5003-JuanitoTest                                                                ', 13012, 0, N'5003-JuanitoTest                                                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14055, N'5006-Pepe Perez                                                                 ', N'4009-BoxeadorTest4                                                              ', 13012, 0, N'5006-Pepe Perez                                                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14056, N'5002-Boxeador12                                                                 ', N'LIBRE                                                                           ', 13012, 0, N'5002-Boxeador12                                                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14057, N'4006-BoxeadorTest1                                                              ', N'5006-Pepe Perez                                                                 ', 13012, 1, N'5006-Pepe Perez                                                                 ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14058, N'LIBRE                                                                           ', N'5004-José Luis                                                                  ', 13012, 1, N'5004-José Luis                                                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14059, N'5003-JuanitoTest                                                                ', N'5002-Boxeador12                                                                 ', 13012, 1, N'5003-JuanitoTest                                                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14060, N'5003-JuanitoTest                                                                ', N'5006-Pepe Perez                                                                 ', 13012, 2, N'5003-JuanitoTest                                                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14061, N'LIBRE                                                                           ', N'5004-José Luis                                                                  ', 13012, 2, N'5004-José Luis                                                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14062, N'5004-José Luis                                                                  ', N'5003-JuanitoTest                                                                ', 13012, 3, N'5003-JuanitoTest                                                                ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14063, N'5003-JuanitoTest                                                                ', N'4005-TestBoxeador                                                               ', 13013, 0, N'4005-TestBoxeador                                                               ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14064, N'4006-BoxeadorTest1                                                              ', N'5004-José Luis                                                                  ', 13013, 0, N'5004-José Luis                                                                  ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14065, N'5002-Boxeador12                                                                 ', N'4008-BoxeadorTest3                                                              ', 13013, 0, N'4008-BoxeadorTest3                                                              ', CAST(0x0000A87100000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14066, N'1002-Hector Flores                                                              ', N'4009-BoxeadorTest4                                                              ', 13013, 0, N'1002-Hector Flores                                                              ', CAST(0x0000A87000000000 AS DateTime))
INSERT [dbo].[Pelea] ([Id_Pelea], [Id_Boxeador1], [Id_Boxeador2], [Id_Torneo], [Etapa], [Ganador], [Fecha]) VALUES (14067, N'5006-Pepe Perez                                                                 ', N'4007-BoxeadorTest2                                                              ', 13013, 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Pelea] OFF
SET IDENTITY_INSERT [dbo].[Torneo] ON 

INSERT [dbo].[Torneo] ([Id_Torneo], [Nombre], [Id_Categoria], [Rama], [NumParticipantes], [FechaCreacion]) VALUES (13012, N'Test                          ', 2, N'Varonil   ', 9, CAST(0x0000A870016CE7A2 AS DateTime))
INSERT [dbo].[Torneo] ([Id_Torneo], [Nombre], [Id_Categoria], [Rama], [NumParticipantes], [FechaCreacion]) VALUES (13013, N'TestEquis                     ', 2, N'Varonil   ', 10, CAST(0x0000A870017A53CE AS DateTime))
SET IDENTITY_INSERT [dbo].[Torneo] OFF
USE [master]
GO
ALTER DATABASE [BoxManagerDB] SET  READ_WRITE 
GO

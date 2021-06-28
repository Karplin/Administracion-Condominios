USE [master]
GO
/****** Object:  Database [condomines]    Script Date: 23/11/2020 15:25:34 ******/
CREATE DATABASE [condomines]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'condomines', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSERVER\MSSQL\DATA\condomines.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'condomines_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSERVER\MSSQL\DATA\condomines_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [condomines] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [condomines].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [condomines] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [condomines] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [condomines] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [condomines] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [condomines] SET ARITHABORT OFF 
GO
ALTER DATABASE [condomines] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [condomines] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [condomines] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [condomines] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [condomines] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [condomines] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [condomines] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [condomines] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [condomines] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [condomines] SET  ENABLE_BROKER 
GO
ALTER DATABASE [condomines] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [condomines] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [condomines] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [condomines] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [condomines] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [condomines] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [condomines] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [condomines] SET RECOVERY FULL 
GO
ALTER DATABASE [condomines] SET  MULTI_USER 
GO
ALTER DATABASE [condomines] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [condomines] SET DB_CHAINING OFF 
GO
ALTER DATABASE [condomines] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [condomines] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [condomines] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'condomines', N'ON'
GO
ALTER DATABASE [condomines] SET QUERY_STORE = OFF
GO
USE [condomines]
GO
/****** Object:  Table [dbo].[apartamentos]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[apartamentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [varchar](15) NOT NULL,
	[edificio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[condominesx]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[condominesx](
	[id_condo] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](25) NULL,
	[nombre] [varchar](12) NULL,
	[correo] [varchar](30) NULL,
	[telefono] [varchar](15) NULL,
	[manzana] [varchar](15) NULL,
	[edificio] [int] NULL,
	[apto] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_condo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[edificios]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[edificios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NOT NULL,
	[cant_pisos] [varchar](12) NULL,
	[cant_aptos] [varchar](12) NULL,
	[manzana] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[manzanas]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[manzanas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pagos]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [varchar](30) NULL,
	[cedula] [varchar](25) NULL,
	[nombre] [varchar](12) NULL,
	[correo] [varchar](30) NULL,
	[telefono] [varchar](15) NULL,
	[manzana] [varchar](15) NULL,
	[edificio] [int] NULL,
	[apto] [varchar](15) NULL,
	[mespago] [varchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reclamaciones]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reclamaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [varchar](30) NULL,
	[cedula] [varchar](25) NULL,
	[nombre] [varchar](12) NULL,
	[correo] [varchar](30) NULL,
	[telefono] [varchar](15) NULL,
	[manzana] [varchar](15) NULL,
	[edificio] [int] NULL,
	[apto] [varchar](15) NULL,
	[reclamacion] [varchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[nombreusuario] [nvarchar](20) NOT NULL,
	[contrasena] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombreusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[apartamentos] ON 
GO
INSERT [dbo].[apartamentos] ([id], [numero], [edificio]) VALUES (6, N'15', 2)
GO
INSERT [dbo].[apartamentos] ([id], [numero], [edificio]) VALUES (4, N'2', 4)
GO
INSERT [dbo].[apartamentos] ([id], [numero], [edificio]) VALUES (5, N'3-1', 2)
GO
SET IDENTITY_INSERT [dbo].[apartamentos] OFF
GO
SET IDENTITY_INSERT [dbo].[condominesx] ON 
GO
INSERT [dbo].[condominesx] ([id_condo], [cedula], [nombre], [correo], [telefono], [manzana], [edificio], [apto]) VALUES (1, N'402-3442231-2', N'Masiro', N'hola@gmail.com', N'8096996023', N'E', 2, N'3-1')
GO
INSERT [dbo].[condominesx] ([id_condo], [cedula], [nombre], [correo], [telefono], [manzana], [edificio], [apto]) VALUES (2, N'402-3390519-5', N'Leonal', N'leonal23@gmail.com', N'809699242', N'E', 2, N'15')
GO
SET IDENTITY_INSERT [dbo].[condominesx] OFF
GO
SET IDENTITY_INSERT [dbo].[edificios] ON 
GO
INSERT [dbo].[edificios] ([id], [numero], [cant_pisos], [cant_aptos], [manzana]) VALUES (10, 2, N'3', N'12', N'E')
GO
INSERT [dbo].[edificios] ([id], [numero], [cant_pisos], [cant_aptos], [manzana]) VALUES (11, 3, N'5', N'6', N'E')
GO
INSERT [dbo].[edificios] ([id], [numero], [cant_pisos], [cant_aptos], [manzana]) VALUES (9, 4, N'7', N'9', N'F')
GO
INSERT [dbo].[edificios] ([id], [numero], [cant_pisos], [cant_aptos], [manzana]) VALUES (13, 5, N'8', N'16', N'Z')
GO
INSERT [dbo].[edificios] ([id], [numero], [cant_pisos], [cant_aptos], [manzana]) VALUES (12, 12, N'2', N'3', N'F')
GO
SET IDENTITY_INSERT [dbo].[edificios] OFF
GO
SET IDENTITY_INSERT [dbo].[manzanas] ON 
GO
INSERT [dbo].[manzanas] ([id], [nombre]) VALUES (5, N'E')
GO
INSERT [dbo].[manzanas] ([id], [nombre]) VALUES (3, N'F')
GO
INSERT [dbo].[manzanas] ([id], [nombre]) VALUES (4, N'G')
GO
INSERT [dbo].[manzanas] ([id], [nombre]) VALUES (7, N'L')
GO
INSERT [dbo].[manzanas] ([id], [nombre]) VALUES (6, N'Z')
GO
SET IDENTITY_INSERT [dbo].[manzanas] OFF
GO
SET IDENTITY_INSERT [dbo].[pagos] ON 
GO
INSERT [dbo].[pagos] ([id], [fecha], [cedula], [nombre], [correo], [telefono], [manzana], [edificio], [apto], [mespago]) VALUES (1, N'23/11/2020 10:44:59', N'402-3442231-2', N'Masiro', N'hola@gmail.com', N'8096996023', N'E', 2, N'3-1', N'Enero')
GO
INSERT [dbo].[pagos] ([id], [fecha], [cedula], [nombre], [correo], [telefono], [manzana], [edificio], [apto], [mespago]) VALUES (2, N'23/11/2020 15:03:17', N'402-3442231-2', N'Masiro', N'hola@gmail.com', N'8096996023', N'E', 2, N'3-1', N'Junio')
GO
SET IDENTITY_INSERT [dbo].[pagos] OFF
GO
SET IDENTITY_INSERT [dbo].[reclamaciones] ON 
GO
INSERT [dbo].[reclamaciones] ([id], [fecha], [cedula], [nombre], [correo], [telefono], [manzana], [edificio], [apto], [reclamacion]) VALUES (1, N'23/11/2020 10:45:18', N'402-3442231-2', N'Masiro', N'hola@gmail.com', N'8096996023', N'E', 2, N'3-1', N'Luz')
GO
SET IDENTITY_INSERT [dbo].[reclamaciones] OFF
GO
INSERT [dbo].[usuarios] ([nombreusuario], [contrasena]) VALUES (N'leo', N'123')
GO
ALTER TABLE [dbo].[apartamentos]  WITH CHECK ADD  CONSTRAINT [FK_Llave_edificio2] FOREIGN KEY([edificio])
REFERENCES [dbo].[edificios] ([numero])
GO
ALTER TABLE [dbo].[apartamentos] CHECK CONSTRAINT [FK_Llave_edificio2]
GO
ALTER TABLE [dbo].[condominesx]  WITH CHECK ADD  CONSTRAINT [FK_Llave_apto] FOREIGN KEY([apto])
REFERENCES [dbo].[apartamentos] ([numero])
GO
ALTER TABLE [dbo].[condominesx] CHECK CONSTRAINT [FK_Llave_apto]
GO
ALTER TABLE [dbo].[condominesx]  WITH CHECK ADD  CONSTRAINT [FK_Llave_edificio] FOREIGN KEY([edificio])
REFERENCES [dbo].[edificios] ([numero])
GO
ALTER TABLE [dbo].[condominesx] CHECK CONSTRAINT [FK_Llave_edificio]
GO
ALTER TABLE [dbo].[condominesx]  WITH CHECK ADD  CONSTRAINT [FK_Llave_Manzana] FOREIGN KEY([manzana])
REFERENCES [dbo].[manzanas] ([nombre])
GO
ALTER TABLE [dbo].[condominesx] CHECK CONSTRAINT [FK_Llave_Manzana]
GO
ALTER TABLE [dbo].[edificios]  WITH CHECK ADD  CONSTRAINT [FK_Llave_Manzana2] FOREIGN KEY([manzana])
REFERENCES [dbo].[manzanas] ([nombre])
GO
ALTER TABLE [dbo].[edificios] CHECK CONSTRAINT [FK_Llave_Manzana2]
GO
/****** Object:  StoredProcedure [dbo].[filtro_edificio]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[filtro_edificio]
@EDIFICIO1 int
AS 
SELECT  * FROM EDIFICIOS WHERE NUMERO = @EDIFICIO1
GO
/****** Object:  StoredProcedure [dbo].[filtro_edificio2]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[filtro_edificio2]
@EDIFICIO2 VARCHAR(10)
AS 
SELECT  * FROM EDIFICIOS WHERE MANZANA = @EDIFICIO2
GO
/****** Object:  StoredProcedure [dbo].[filtro_edificio3]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[filtro_edificio3]
@EDIFICIO3 VARCHAR(10)
AS 
SELECT  * FROM EDIFICIOS WHERE CANT_APTOS = @EDIFICIO3
GO
/****** Object:  StoredProcedure [dbo].[filtro_mines1]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[filtro_mines1]
@MINES1 VARCHAR(25)
AS 
SELECT  * FROM CONDOMINESX WHERE CEDULA = @MINES1
GO
/****** Object:  StoredProcedure [dbo].[filtro_mines2]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[filtro_mines2]
@MINES2 VARCHAR(30)
AS 
SELECT  * FROM CONDOMINESX WHERE CORREO = @MINES2
GO
/****** Object:  StoredProcedure [dbo].[filtro_mines3]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[filtro_mines3]
@MINES3 int
AS 
SELECT  * FROM CONDOMINESX WHERE EDIFICIO = @MINES3
GO
/****** Object:  StoredProcedure [dbo].[filtro_pagosx]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[filtro_pagosx]
@fechaini VARCHAR(30),
@fechafi VARCHAR(30)
AS 
SELECT  * FROM PAGOS WHERE  FECHA BETWEEN @fechaini AND @fechafi 
GO
/****** Object:  StoredProcedure [dbo].[filtro_reclamaciones]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[filtro_reclamaciones]
@RECLAMACION int
AS 
SELECT  * FROM RECLAMACIONES WHERE EDIFICIO = @RECLAMACION
GO
/****** Object:  StoredProcedure [dbo].[generar_re]    Script Date: 23/11/2020 15:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[generar_re]
@REGISTRO VARCHAR(10)
AS 
SELECT  * FROM MANZANAS WHERE NOMBRE = @REGISTRO
GO
USE [master]
GO
ALTER DATABASE [condomines] SET  READ_WRITE 
GO

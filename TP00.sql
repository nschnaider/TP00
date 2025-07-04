USE [master]
GO
/****** Object:  Database [TP00]    Script Date: 2/7/2025 08:57:20 ******/
CREATE DATABASE [TP00]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP00', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TP00.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP00_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TP00_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TP00] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP00].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP00] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP00] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP00] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP00] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP00] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP00] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP00] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP00] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP00] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP00] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP00] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP00] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP00] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP00] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP00] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP00] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP00] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP00] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP00] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP00] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP00] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP00] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP00] SET RECOVERY FULL 
GO
ALTER DATABASE [TP00] SET  MULTI_USER 
GO
ALTER DATABASE [TP00] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP00] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP00] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP00] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP00] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP00', N'ON'
GO
ALTER DATABASE [TP00] SET QUERY_STORE = OFF
GO
USE [TP00]
GO
/****** Object:  User [alumno]    Script Date: 2/7/2025 08:57:21 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Integrantes]    Script Date: 2/7/2025 08:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Integrantes](
	[IDintegrante] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Tiempo] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
 CONSTRAINT [PK_Integrantes] PRIMARY KEY CLUSTERED 
(
	[IDintegrante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [TP00] SET  READ_WRITE 
GO

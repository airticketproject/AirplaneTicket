USE [master]
GO

/****** Object:  Database [QLBVMB]    Script Date: 04/06/2019 9:27:14 CH ******/
CREATE DATABASE [QLBVMB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBVMB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLBVMB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBVMB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLBVMB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [QLBVMB] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBVMB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QLBVMB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QLBVMB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QLBVMB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QLBVMB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QLBVMB] SET ARITHABORT OFF 
GO

ALTER DATABASE [QLBVMB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QLBVMB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QLBVMB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QLBVMB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QLBVMB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QLBVMB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QLBVMB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QLBVMB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QLBVMB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QLBVMB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [QLBVMB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QLBVMB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QLBVMB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QLBVMB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QLBVMB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QLBVMB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QLBVMB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QLBVMB] SET RECOVERY FULL 
GO

ALTER DATABASE [QLBVMB] SET  MULTI_USER 
GO

ALTER DATABASE [QLBVMB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QLBVMB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QLBVMB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QLBVMB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [QLBVMB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QLBVMB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [QLBVMB] SET  READ_WRITE 
GO

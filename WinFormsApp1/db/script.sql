USE [master]
GO

/****** Object:  Database [shir]    Script Date: 11.12.2023 5:16:40 ******/
CREATE DATABASE [shir]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'shir', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\shir.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'shir_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\shir_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [shir].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [shir] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [shir] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [shir] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [shir] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [shir] SET ARITHABORT OFF 
GO

ALTER DATABASE [shir] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [shir] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [shir] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [shir] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [shir] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [shir] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [shir] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [shir] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [shir] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [shir] SET  ENABLE_BROKER 
GO

ALTER DATABASE [shir] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [shir] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [shir] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [shir] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [shir] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [shir] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [shir] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [shir] SET RECOVERY FULL 
GO

ALTER DATABASE [shir] SET  MULTI_USER 
GO

ALTER DATABASE [shir] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [shir] SET DB_CHAINING OFF 
GO

ALTER DATABASE [shir] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [shir] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [shir] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [shir] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [shir] SET QUERY_STORE = OFF
GO

ALTER DATABASE [shir] SET  READ_WRITE 
GO


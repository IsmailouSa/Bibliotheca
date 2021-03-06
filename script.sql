USE [master]
GO
/****** Object:  Database [Bibliotheca]    Script Date: 28-Feb-17 9:30:21 PM ******/
CREATE DATABASE [Bibliotheca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bibliotheca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Bibliotheca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Bibliotheca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Bibliotheca_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Bibliotheca] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bibliotheca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bibliotheca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bibliotheca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bibliotheca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bibliotheca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bibliotheca] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bibliotheca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bibliotheca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bibliotheca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bibliotheca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bibliotheca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bibliotheca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bibliotheca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bibliotheca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bibliotheca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bibliotheca] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bibliotheca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bibliotheca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bibliotheca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bibliotheca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bibliotheca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bibliotheca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bibliotheca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bibliotheca] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bibliotheca] SET  MULTI_USER 
GO
ALTER DATABASE [Bibliotheca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bibliotheca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bibliotheca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bibliotheca] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Bibliotheca] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Bibliotheca]
GO
/****** Object:  Table [dbo].[Book_category]    Script Date: 28-Feb-17 9:30:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book_category](
	[BookCat_Id] [int] IDENTITY(1,1) NOT NULL,
	[BookCat_Name] [varchar](50) NOT NULL,
	[status] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Book_category] PRIMARY KEY CLUSTERED 
(
	[BookCat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Books]    Script Date: 28-Feb-17 9:30:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Books](
	[Book_Id] [int] IDENTITY(1,1) NOT NULL,
	[BookCat_Id] [int] NULL,
	[Book_Title] [varchar](100) NOT NULL,
	[Book_Author] [varchar](50) NOT NULL,
	[yr_of_publ] [varchar](20) NULL,
	[Book_Qty] [int] NOT NULL,
	[status] [varchar](20) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Book_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Issue_book]    Script Date: 28-Feb-17 9:30:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Issue_book](
	[issue_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[issue_date] [date] NOT NULL,
	[due_date] [date] NULL,
	[status] [varchar](20) NULL,
	[user_role] [varchar](20) NULL,
 CONSTRAINT [PK_Issue_book] PRIMARY KEY CLUSTERED 
(
	[issue_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Members]    Script Date: 28-Feb-17 9:30:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Members](
	[Mem_Id] [int] IDENTITY(1,1) NOT NULL,
	[Mem_password] [varchar](20) NOT NULL,
	[Mem_Name] [varchar](100) NOT NULL,
	[Mem_Email] [varchar](100) NOT NULL,
	[Mem_Address] [varchar](200) NULL,
	[Mem_Role] [varchar](50) NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[Mem_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Penalty]    Script Date: 28-Feb-17 9:30:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Penalty](
	[penalty_id] [int] IDENTITY(1,1) NOT NULL,
	[psid] [int] NOT NULL,
	[days] [varchar](20) NOT NULL,
	[penalty] [float] NOT NULL,
	[user_id] [int] NOT NULL,
	[book_id] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Penalty] PRIMARY KEY CLUSTERED 
(
	[penalty_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Return_book]    Script Date: 28-Feb-17 9:30:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Return_book](
	[return_id] [int] IDENTITY(1,1) NOT NULL,
	[issue_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[return_date] [date] NOT NULL,
	[status] [varchar](20) NULL,
	[user_role] [varchar](20) NULL,
 CONSTRAINT [PK_Return_book] PRIMARY KEY CLUSTERED 
(
	[return_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [Bibliotheca] SET  READ_WRITE 
GO

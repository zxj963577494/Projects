USE [master]
GO
/****** Object:  Database [ActiveRecord_Blog]    Script Date: 11/12/2014 13:30:45 ******/
CREATE DATABASE [ActiveRecord_Blog] ON  PRIMARY 
( NAME = N'ActiveRecord_Blog', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\Data\ActiveRecord_Blog.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ActiveRecord_Blog_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\Data\ActiveRecord_Blog_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ActiveRecord_Blog] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ActiveRecord_Blog].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ActiveRecord_Blog] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET ARITHABORT OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ActiveRecord_Blog] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ActiveRecord_Blog] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ActiveRecord_Blog] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET  DISABLE_BROKER
GO
ALTER DATABASE [ActiveRecord_Blog] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ActiveRecord_Blog] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ActiveRecord_Blog] SET  READ_WRITE
GO
ALTER DATABASE [ActiveRecord_Blog] SET RECOVERY FULL
GO
ALTER DATABASE [ActiveRecord_Blog] SET  MULTI_USER
GO
ALTER DATABASE [ActiveRecord_Blog] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ActiveRecord_Blog] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'ActiveRecord_Blog', N'ON'
GO
USE [ActiveRecord_Blog]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/12/2014 13:30:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](64) NULL,
	[Description] [nvarchar](512) NULL,
	[DateAdded] [datetime] NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 11/12/2014 13:30:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Subject] [nvarchar](64) NULL,
	[Text] [nvarchar](1024) NULL,
	[DateAdded] [datetime] NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 11/12/2014 13:30:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](1024) NULL,
	[Author] [nvarchar](64) NULL,
	[DateAdded] [datetime] NULL,
	[PostId] [int] NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category_Post]    Script Date: 11/12/2014 13:30:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category_Post](
	[Category_Id] [int] NOT NULL,
	[Post_Id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Comment_Post]    Script Date: 11/12/2014 13:30:46 ******/
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Post] FOREIGN KEY([PostId])
REFERENCES [dbo].[Post] ([Id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Post]
GO
/****** Object:  ForeignKey [FK_Category_Post_Category]    Script Date: 11/12/2014 13:30:46 ******/
ALTER TABLE [dbo].[Category_Post]  WITH CHECK ADD  CONSTRAINT [FK_Category_Post_Category] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Category_Post] CHECK CONSTRAINT [FK_Category_Post_Category]
GO
/****** Object:  ForeignKey [FK_Category_Post_Post1]    Script Date: 11/12/2014 13:30:46 ******/
ALTER TABLE [dbo].[Category_Post]  WITH CHECK ADD  CONSTRAINT [FK_Category_Post_Post1] FOREIGN KEY([Post_Id])
REFERENCES [dbo].[Post] ([Id])
GO
ALTER TABLE [dbo].[Category_Post] CHECK CONSTRAINT [FK_Category_Post_Post1]
GO

CREATE DATABASE [Library]
GO

USE [Library]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [varchar](100) NOT NULL,
	[AuthorName] [varchar](100) NOT NULL,
	[Category] [varchar](100) NOT NULL,
	[Edition] [varchar](100) NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [float] NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [varchar](100) NOT NULL,
	[Description] [varchar](1000) NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](100) NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)
) ON [PRIMARY]
GO

Insert Into [Authors] ([AuthorName],[Description],[CreatedBy],[CreatedDate],[ModifiedBy],[ModifiedDate]) Values ('Akilan','Akilan was a Tamil author noted for his realistic and creative writing style. Akilan was a freedom fighter, novelist, short-story writer, journalist, satirist, travel writer, playwright, script-writer, orator and critic. He is also a children novelist','SYS-Created',GetDate(),'SYS-Created',GetDate())
Insert Into [Categories] ([CategoryName],[CreatedBy],[CreatedDate],[ModifiedBy],[ModifiedDate]) Values ('Comics','SYS-Created',GetDate(),'SYS-Created',GetDate())
Insert Into [Books] ([BookName],[AuthorName],[Category],[Edition],[Publisher],[Price],[CreatedBy],[CreatedDate],[ModifiedBy],[ModifiedDate]) Values ('Vengayin Maindan','Akilan','Comics','First Edition','Chennai Books',414.00,'SYS-Created',GetDate(),'SYS-Created',GetDate())
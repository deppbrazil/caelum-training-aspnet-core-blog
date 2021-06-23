USE [Blog]
GO

/****** Object: Table [dbo].[Posts] Script Date: 6/23/2021 1:56:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Title]    VARCHAR (50)  NULL,
    [Resume]   VARCHAR (500) NULL,
    [Category] VARCHAR (50)  NULL
);


SELECT * FROM [dbo].[Posts];

INSERT INTO [dbo].[Posts]
	VALUES  ('Filme1','Resumo filme 1','Ação');

DELETE FROM [dbo].[Posts]
  --WHERE Id = '';
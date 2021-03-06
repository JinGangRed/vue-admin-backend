/** create database **/
IF NOT EXISTS(SELECT * FROM	SYS.DATABASES WHERE NAME = 'admin_analysis')
CREATE DATABASE admin_analysis;
GO

USE admin_analysis;
GO

IF NOT EXISTS( SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('Role'))
CREATE TABLE [Role](
[Id] INT NOT NULL IDENTITY(1,2),
[RoleName] NVARCHAR(200) NOT NULL,
[RoleCNName] NVARCHAR(200),
[Status] INT NOT NULL,
[CreateTime] DATETIME NULL,
[CreateBy] NVARCHAR(200) NULL,
[UpdateTime] DATETIME NULL,
[UpdateBy] NVARCHAR(200) NULL,
CONSTRAINT [PK_Role] PRIMARY KEY ([Id])
);
GO

IF NOT EXISTS( SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('Menu'))
CREATE TABLE [Menu](
[Id] UNIQUEIDENTIFIER NOT NULL,
[Order] INT NOT NULL,
[Url] NVARCHAR(200) NOT NULL,
[Name] NVARCHAR(512) NOT NULL,
[Status] INT NOT NULL,
[CreateTime] DATETIME NULL,
[CreateBy] NVARCHAR(200) NULL,
[UpdateTime] DATETIME NULL,
[UpdateBy] NVARCHAR(200) NULL,
CONSTRAINT [PK_Menu] PRIMARY KEY ([Id])
);
GO

INSERT INTO [Menu]([Id],[Order],[Url],[Name],[Status],[CreateTime],[CreateBy],[UpdateTime],[UpdateBy])VALUES
(NEWID(),1,'/',N'首页',1,GETDATE(),'System',NULL,NULL),
(NEWID(),1,'/',N'导航一',1,GETDATE(),'System',NULL,NULL),
(NEWID(),1,'/',N'导航二',1,GETDATE(),'System',NULL,NULL);
USE [master]
GO
/****** Object:  Database [MonitorClient]    Script Date: 6/16/2020 2:39:23 PM ******/
CREATE DATABASE [MonitorClient]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MonitorClient', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MonitorClient.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MonitorClient_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MonitorClient_log.ldf' , SIZE = 401408KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MonitorClient] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MonitorClient].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MonitorClient] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MonitorClient] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MonitorClient] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MonitorClient] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MonitorClient] SET ARITHABORT OFF 
GO
ALTER DATABASE [MonitorClient] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MonitorClient] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MonitorClient] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MonitorClient] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MonitorClient] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MonitorClient] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MonitorClient] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MonitorClient] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MonitorClient] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MonitorClient] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MonitorClient] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MonitorClient] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MonitorClient] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MonitorClient] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MonitorClient] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MonitorClient] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MonitorClient] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MonitorClient] SET RECOVERY FULL 
GO
ALTER DATABASE [MonitorClient] SET  MULTI_USER 
GO
ALTER DATABASE [MonitorClient] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MonitorClient] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MonitorClient] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MonitorClient] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MonitorClient] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MonitorClient', N'ON'
GO
ALTER DATABASE [MonitorClient] SET QUERY_STORE = OFF
GO
USE [MonitorClient]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MonitorClient]
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Computers](
	[ComputerID] [varchar](128) NOT NULL,
	[ComputerName] [nvarchar](255) NULL,
	[CPUName] [nvarchar](255) NULL,
	[RAM] [varchar](10) NULL,
	[OS] [nvarchar](128) NULL,
	[OSReleaseId] [varchar](20) NULL,
	[Status] [bit] NULL,
	[Ping] [varchar](10) NULL,
	[CreateAt] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[RoomID] [int] NULL,
	[AgentVersion] [nvarchar](50) NULL,
	[DotNetVersion] [nvarchar](50) NULL,
	[State] [varchar](20) NULL,
 CONSTRAINT [PK_Computers] PRIMARY KEY CLUSTERED 
(
	[ComputerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComputersStatusLogs]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComputersStatusLogs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ComputerID] [varchar](128) NULL,
	[Time] [datetime] NULL,
	[Tag] [bit] NULL,
 CONSTRAINT [PK_ComputersStatusLogs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log4NetLog]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log4NetLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] [nvarchar](255) NOT NULL,
	[Level] [nvarchar](50) NOT NULL,
	[Logger] [nvarchar](255) NOT NULL,
	[Message] [nvarchar](4000) NOT NULL,
	[Exception] [nvarchar](2000) NULL,
 CONSTRAINT [PK_Log4NetLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NetworkInterfaces]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NetworkInterfaces](
	[NetInterfaceID] [int] IDENTITY(1,1) NOT NULL,
	[NetInterfaceName] [nvarchar](255) NULL,
	[List_IPv4] [varchar](max) NULL,
	[MAC] [varchar](25) NULL,
	[Description] [nvarchar](255) NULL,
	[LastUpdate] [datetime] NULL,
	[Status] [bit] NULL,
	[ComputerID] [varchar](128) NULL,
	[State] [varchar](10) NULL,
 CONSTRAINT [PK_NetworkInterfaces] PRIMARY KEY CLUSTERED 
(
	[NetInterfaceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[RoomName] [nvarchar](255) NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[SettingID] [int] IDENTITY(1,1) NOT NULL,
	[SettingName] [nvarchar](255) NULL,
	[SettingValue] [nvarchar](255) NULL,
 CONSTRAINT [PK_Setting] PRIMARY KEY CLUSTERED 
(
	[SettingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rooms] ADD  CONSTRAINT [DF_Rooms_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  StoredProcedure [dbo].[Create_ComputersStatusLog]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Create_ComputersStatusLog] @ComputerID varchar(128), @Time datetime
as

INSERT INTO [ComputersStatusLogs] ([ComputerID] ,[Time], [Tag]) VALUES (@ComputerID ,@Time, 0);

INSERT INTO [ComputersStatusLogs] ([ComputerID] ,[Time], [Tag]) OUTPUT Inserted.ID VALUES (@ComputerID ,@Time, 1);

GO
/****** Object:  StoredProcedure [dbo].[Delete_Computer]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_Computer] 
	-- Add the parameters for the stored procedure here
	@ComputerID varchar(128)
AS
BEGIN
	delete from NetworkInterfaces where ComputerID = @ComputerID;

	delete from Computers where ComputerID = @ComputerID;
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_or_Update_Computer]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[Insert_or_Update_Computer] @_ComputerID varchar(128),
           @_ComputerName nvarchar(255),
           @_CPUName nvarchar(255),
           @_RAM varchar(10),
           @_OS nvarchar(128),
           @_OSReleaseId varchar(20),
           @_Status bit,
           @_Ping varchar(10),
           @_RoomID int,
           @_AgentVersion nvarchar(50),
		   @_DotNetVersion nvarchar(50),
		   @_State varchar(20)
as
UPDATE Computers SET [ComputerName] = @_ComputerName
      ,[CPUName] = @_CPUName
      ,[RAM] = @_RAM
      ,[OS] = @_OS
      ,[OSReleaseId] = @_OSReleaseId
      ,[Ping] = @_Ping
      ,[LastUpdate] = GETDATE()
      ,[RoomID] = @_RoomID
      ,[AgentVersion] = @_AgentVersion  
	  ,[DotNetVersion] = @_DotNetVersion
	  ,[State] = @_State
	  WHERE ComputerID = @_ComputerID

IF @@ROWCOUNT = 0
   INSERT INTO [Computers]
           ([ComputerID]
           ,[ComputerName]
           ,[CPUName]
           ,[RAM]
           ,[OS]
           ,[OSReleaseId]
           ,[Status]
           ,[Ping]
           ,[CreateAt]
           ,[LastUpdate]
           ,[RoomID]
           ,[AgentVersion]
		   ,[DotNetVersion]
		   ,[State])
     VALUES
           (@_ComputerID, 
		   @_ComputerName,
           @_CPUName,
           @_RAM,
           @_OS,
           @_OSReleaseId,
           @_Status,
           @_Ping,
           GETDATE(),
           GETDATE(),
           @_RoomID,
           @_AgentVersion,
		   @_DotNetVersion,
		   @_State)
GO
/****** Object:  StoredProcedure [dbo].[Insert_or_Update_NetworkInterfaces]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_or_Update_NetworkInterfaces] @_NetInterfaceName nvarchar(255),
           @_List_IPv4 varchar(max),
           @_MAC varchar(25),
           @_Description nvarchar(255),
           @_Status bit,
           @_ComputerID varchar(128),
		   @_State varchar(10)
as 

UPDATE [NetworkInterfaces]
   SET [NetInterfaceName] = @_NetInterfaceName
      ,[List_IPv4] = @_List_IPv4
      ,[MAC] = @_MAC
      ,[Description] = @_Description
      ,[LastUpdate] = GETDATE()
      ,[ComputerID] = @_ComputerID
	  ,[State] = @_State
 WHERE [NetworkInterfaces].ComputerID = @_ComputerID and [NetworkInterfaces].MAC = @_MAC

 IF @@ROWCOUNT = 0

INSERT INTO [NetworkInterfaces]
           ([NetInterfaceName]
           ,[List_IPv4]
           ,[MAC]
           ,[Description]
		   ,[LastUpdate]
           ,[Status]
           ,[ComputerID]
		   ,[State])
     VALUES
           (@_NetInterfaceName
           ,@_List_IPv4
           ,@_MAC
           ,@_Description
           ,GETDATE()
           ,@_Status
           ,@_ComputerID
		   ,@_State)
GO
/****** Object:  StoredProcedure [dbo].[Update_ComputersStatusLog]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_ComputersStatusLog] @ID int, @Time datetime
as

update [ComputersStatusLogs] set Time = @Time where ID = @ID;

GO
/****** Object:  StoredProcedure [dbo].[Update_Status_Computer]    Script Date: 6/16/2020 2:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_Status_Computer]
as
WHILE (1 = 1) 
BEGIN
 WAITFOR DELAY '00:00:08';
 update Computers set Status = 0;

END;
GO
USE [master]
GO
ALTER DATABASE [MonitorClient] SET  READ_WRITE 
GO

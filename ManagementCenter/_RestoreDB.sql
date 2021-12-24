EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'%_DBNAME_%'
GO
USE [master]
GO
ALTER DATABASE [%_DBNAME_%] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
USE [master]
GO
DROP DATABASE [%_DBNAME_%]
GO
create database [%_DBNAME_%];
GO
use [%_DBNAME_%]
GO

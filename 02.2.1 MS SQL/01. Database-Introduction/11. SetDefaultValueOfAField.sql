--USE [Minions]

-- The GETDATE() function returns the current DATABASE SYSTEM date and time, in a 'YYYY-MM-DD hh:mm:ss.mmm' format.
-- https://www.w3schools.com/sql/func_sqlserver_getdate.asp

-- The CURRENT_TIMESTAMP function returns the current date and time, in a 'YYYY-MM-DD hh:mm:ss.mmm' format.
-- https://www.w3schools.com/sql/func_sqlserver_current_timestamp.asp

ALTER TABLE [Users]
ADD CONSTRAINT [DF_UsersLastLoginTime] DEFAULT GETDATE() FOR [LastLoginTime]


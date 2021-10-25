--USE [Minions]

ALTER TABLE [Users]
ADD CONSTRAINT CHK_UsersPassword CHECK (LEN([Password]) >= 5)
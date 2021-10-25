--USE [Minions]

ALTER TABLE [Users]
DROP CONSTRAINT [PK_UsersIdUsername]

ALTER TABLE [Users]
ADD CONSTRAINT [PK_UsersId] PRIMARY KEY ([Id])

ALTER TABLE [Users]
ADD CONSTRAINT [CHK_UsersUsername] CHECK (LEN(Username) >= 3)
USE [Minions]

CREATE TABLE [Minions](
	[Id] INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	[Age] INT
)

CREATE TABLE [Towns](
	[Id] INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL
)

-- or

--CREATE TABLE [Minions](
--	[Id] INT NOT NULL,
--	[Name] NVARCHAR(50) NOT NULL,
--	[Age] INT
--)

--CREATE TABLE [Towns](
--	[Id] INT NOT NULL,
--	[Name] NVARCHAR(50) NOT NULL
--)

--ALTER TABLE [Minions]
--ADD CONSTRAINT PK_MinionsId PRIMARY KEY ([Id])

--ALTER TABLE [Towns]
--ADD CONSTRAINT PK_TownsId PRIMARY KEY ([Id])
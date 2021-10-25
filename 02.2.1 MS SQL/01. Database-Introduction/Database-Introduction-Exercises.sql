-- Problem 1
CREATE DATABASE [Minions]

GO

USE [Minions]

-- Problem 2
CREATE TABLE [Minions](
	[Id] INT,
	[Name] NVARCHAR(50) NOT NULL,
	[Age] INT
)

ALTER TABLE [Minions]
ADD CONSTRAINT PK_MinionsID PRIMARY KEY (Id)

-- In order column [Id] to be primary key, it should be set to NOT NULL,
-- that is why we delete the table 
DROP TABLE [Minions]

-- The way where we
-- 1. create the table and then
-- 2. add the primary key constraint
-- is not a good way to do it!
-- It is done here for learning purposes!
CREATE TABLE [Minions](
	[Id] INT NOT NULL, -- This time we set the [Id] to NULL, so we can make it primary key
	[Name] NVARCHAR(50) NOT NULL,
	[Age] INT
)

-- Set the primary key
ALTER TABLE [Minions] -- ALTER TABLE changes the table structure not the data  
ADD CONSTRAINT PK_MinionsId PRIMARY KEY (Id)

-- Good way to set the primary key!
-- Primary key is set on table creation!
CREATE TABLE [Towns](
	[Id] INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL
)

GO

-- Problem 3
-- Add column TownId
ALTER TABLE [Minions]
ADD [TownId] INT

-- Set TownId as foreign key (FK) to Id in table Towns
ALTER TABLE [Minions]
ADD CONSTRAINT [FK_MinionsTownId] FOREIGN KEY ([TownId]) REFERENCES [Towns]([Id])

GO

-- Problem 4 
-- Start inserting data first into the tables that 
-- do not have foreign key (FK)
INSERT INTO [Towns] ([Id], [Name]) VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO [Minions] ([Id], [Name], [Age], [TownId]) VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)

GO

-- Problem 5
TRUNCATE TABLE [Minions]

GO

-- Problem 6
DROP TABLE [Minions]

DROP TABLE [Towns]

GO

-- Problem 7

-- DECIMAL(PRECISION, SCALE)
-- PRECISION: The maximum total number of decimal digits to be stored. 
-- This number includes both the left and the right sides of the decimal point.
-- SCALE: The number of decimal digits that are stored to the right of the decimal point.

-- IDENTITY[(seed, increment)]
-- seed: the value that is used for the very first row loaded into the table.
-- increment: the incremental value that is added to the identity value of the previous row that was loaded.
-- You must specify both the seed and increment or neither. 
-- If neither is specified, the default is (1,1).
CREATE TABLE [People](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] NVARCHAR(200) NOT NULL,
	[Picture] VARBINARY(MAX),
	[Height] DECIMAL(3,2), 					   
	[Weight] DECIMAL(5,2),
	[Gender] CHAR(1) NOT NULL,
	[Birthdate] DATE NOT NULL,
	[Biography] NVARCHAR(MAX)
)

-- Height should be in meters 
-- People's height is less than 3 meters, e.g. 1.79m
-- SCALE is given and equals 2, so
-- 1 digit before the floating point plus 
-- 2 digits after
-- thus PRECISION is 3

-- Weight should be in kilograms 
-- People's weight is less than 1000 kilograms, e.g. 105.50kg
-- SCALE is given and equals 2, so
-- 3 digit before the floating point plus
-- 2 digits after
-- thus PRECISION is 5

INSERT INTO [People] ([Name], [Picture], [Height], [Weight], [Gender], [Birthdate], [Biography])
VALUES ('Stamo Petkov', NULL, 1.75, 80.95, 'm', '1978-06-01', 'Stamo''s Biography'),
('Nikolay Kostov', NULL, 1.78, 75.53, 'm', '1988-09-06', 'Niki''s Biography'),
('Svetlin Nakov', NULL, 1.82, 82.70, 'm', '1979-03-03', 'Svetlin''s Biography'),
('Ivaylo Kenov', NULL, 1.87, 85.28, 'm', '1989-10-01', 'Ivaylo''s Biography'),
('Ines Ivanova', NULL, 1.69, 45.23, 'f', '1996-05-24', 'Ines'' Biography')

/* INSERT INTO [People] ([Name], [Picture], [Height], [Weight], [Gender], [Birthdate], [Biography])
VALUES ('Stamo Petkov', NULL, 1.75, 80.95, 'm', '1978-06-01', 'Stamo''s Biography'),
('Nikolay Kostov', NULL, 1.78, 75.53, 'm', '1988-09-06', 'Niki''s Biography'),
('Svetlin Nakov', NULL, 1.82, 82.70, 'm', '1979-03-03', 'Svetlin''s Biography'),
('Ivaylo Kenov', NULL, 1.87, 85.28, 'm', '1989-10-01', 'Ivaylo''s Biography'),
(N'Инес Иванова', NULL, 1.69, 45.23, 'f', '1996-05-24', N'Биография на Инес') */

--TRUNCATE TABLE [People]

INSERT INTO [People] ([Name], [Picture], [Height], [Weight], [Gender], [Birthdate], [Biography])
VALUES (N'Тошо', NULL, 1.75, 80.95, 'm', '1978-06-01', 'Bio')


GO

-- Problem 8
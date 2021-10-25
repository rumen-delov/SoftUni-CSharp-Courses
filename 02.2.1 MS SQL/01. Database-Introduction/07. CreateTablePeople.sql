--CREATE DATABASE [Minions]
--COLLATE Cyrillic_General_CI_AS

USE [Minions]

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

INSERT INTO [People] ([Name], [Picture], [Height], [Weight], [Gender], [Birthdate], [Biography]) VALUES 
	('Стамо Петков', NULL, 1.75, 80.95, 'm', '1978-06-01', 'Stamo''s Biography'),
	('Николай Костов', NULL, 1.78, 75.53, 'm', '1988-09-06', 'Niki''s Biography'),
	('Светлин Наков', NULL, 1.82, 82.70, 'm', '1979-03-03', 'Svetlin''s Biography'),
	('Ивайло Кенов', NULL, 1.87, 85.28, 'm', '1989-10-01', 'Ivaylo''s Biography'),
	('Инес Иванова', NULL, 1.69, 45.23, 'f', '1996-05-24', 'Ines'' Biography')

--INSERT INTO [People] ([Name], [Picture], [Height], [Weight], [Gender], [Birthdate], [Biography]) VALUES 
--	('Stamo Petkov', NULL, 1.75, 80.95, 'm', '1978-06-01', 'Stamo''s Biography'),
--	('Nikolay Kostov', NULL, 1.78, 75.53, 'm', '1988-09-06', 'Niki''s Biography'),
--	('Svetlin Nakov', NULL, 1.82, 82.70, 'm', '1979-03-03', 'Svetlin''s Biography'),
--	('Ivaylo Kenov', NULL, 1.87, 85.28, 'm', '1989-10-01', 'Ivaylo''s Biography'),
--	('Ines Ivanova', NULL, 1.69, 45.23, 'f', '1996-05-24', 'Ines'' Biography')

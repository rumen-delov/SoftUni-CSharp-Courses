--CREATE DATABASE [EntityRelations]

--USE [EntityRelations]

CREATE TABLE [Passports](
	[PassportID] INT PRIMARY KEY,
	[PassportNumber] CHAR(8) UNIQUE NOT NULL
)

CREATE TABLE [Persons](
	[PersonID] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(50) NOT NULL,
	[Salary] DECIMAL(9, 2) NOT NULL,
	[PassportID] INT FOREIGN KEY REFERENCES [Passports]([PassportID]) UNIQUE -- it could be NULL in case the pasport is not in the system yet
)

INSERT INTO [Passports] ([PassportID], [PassportNumber])
     VALUES (101, 'N34FG21B'),
            (102, 'K65LO4R7'),
            (103, 'ZE657QP2')

INSERT INTO [Persons] ([FirstName], [Salary], [PassportID])
     VALUES ('Roberto', 43300.00, 102),
            ('Tom', 56100.00, 103),
            ('Yana', 60200.00, 101)

--SELECT * FROM [Passports]
--SELECT * FROM [Persons]
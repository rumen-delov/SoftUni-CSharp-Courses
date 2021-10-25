--CREATE DATABASE [University]

--USE [University]

CREATE TABLE [Majors](
	[MajorID] INT PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
	)

CREATE TABLE [Students](
	[StudentID] INT PRIMARY KEY,
	[StudentNumber] INT UNIQUE NOT NULL,
	[StudentName] VARCHAR(50) NOT NULL,
	[MajorID] INT FOREIGN KEY REFERENCES [Majors]([MajorID])
)

CREATE TABLE [Payments](
	[PaymentID] INT PRIMARY KEY,
	[PaymentDate] DATE NOT NULL,
	[PaymentAmount] DECIMAL(6, 2) NOT NULL,
	[StudentID] INT FOREIGN KEY REFERENCES [Students]([StudentID]) NOT NULL
)

CREATE TABLE [Subjects](
	[SubjectID] INT PRIMARY KEY,
	[SubjectName] VARCHAR(50) NOT NULL
)

CREATE TABLE [Agenda](
	[StudentID] INT FOREIGN KEY REFERENCES [Students]([StudentID]) NOT NULL,
	[SubjectID] INT FOREIGN KEY REFERENCES [Subjects]([SubjectID]) NOT NULL
	CONSTRAINT [PK_Agenda] PRIMARY KEY([StudentID], [SubjectID])
)
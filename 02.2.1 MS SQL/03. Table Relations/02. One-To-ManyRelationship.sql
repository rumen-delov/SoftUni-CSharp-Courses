--USE [EntityRelations]

CREATE TABLE [Manufacturers]( 
	[ManufacturerID] INT PRIMARY KEY IDENTITY, 
	[Name] VARCHAR(50) NOT NULL,
	[EstablishedOn] DATE NOT NULL -- or maybe NULL
)

CREATE TABLE [Models](
	[ModelID] INT PRIMARY KEY IDENTITY(101, 1),
	[Name] VARCHAR(50) NOT NULL, 
	[ManufacturerID] INT FOREIGN KEY REFERENCES [Manufacturers]([ManufacturerID]) NOT NULL -- or maybe NULL
)

INSERT INTO [Manufacturers]([Name], [EstablishedOn])
	 VALUES ('BMW', '1916-03-07'),
			('Tesla', '2003-01-01'),
			('Lada', '1966-05-01')

INSERT INTO [Models]([Name], [ManufacturerID])
	 VALUES ('X1', 1),
			('i6', 1),
			('Model S', 2),
			('Model X',	2),
			('Model 3', 2),
			('Nova', 3)

--SELECT * FROM [Manufacturers]
--SELECT * FROM [Models]

/* Join of the two tables */

--SELECT * FROM Models AS mo
--JOIN Manufacturers AS ma
--ON mo.ManufacturerID=ma.ManufacturerID


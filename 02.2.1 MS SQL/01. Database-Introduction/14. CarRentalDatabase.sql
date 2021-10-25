--CREATE DATABASE [CarRental]

--USE [CarRental]

CREATE TABLE [Categories](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[CategoryName] VARCHAR(50) NOT NULL,
	[DailyRate] DECIMAL(6,2),
	[WeeklyRate] DECIMAL(6,2),
	[MonthlyRate] DECIMAL(6,2),
	[WeekendRate] DECIMAL(6,2)
)

INSERT INTO [Categories] ([CategoryName], [DailyRate], [WeeklyRate], [MonthlyRate], [WeekendRate])
	VALUES ('City car', 128.73, 408.47, 1240.03, 171.13),
	('Electric', 132.55, 472.37, 1521.22, 196.20),
	('Prestige', 227.23, 708.31, 2204.71, 330.34)

CREATE TABLE [Cars](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[PlateNumber] NVARCHAR(12) UNIQUE NOT NULL,
	[Manufacturer] NVARCHAR(50) NOT NULL,
	[Model] NVARCHAR(50) NOT NULL,
	[CarYear] INT NOT NULL,	
	[CategoryId] INT FOREIGN KEY REFERENCES [Categories]([Id]),
	[Doors] TINYINT NOT NULL,
	[Picture] VARBINARY(MAX),--or IMAGE?
	[Condition] NVARCHAR(20),
	[Available] BIT DEFAULT 'true' NOT NULL
)

INSERT INTO [Cars] ([PlateNumber], [Manufacturer], [Model], [CarYear], [CategoryId], [Doors], [Picture], [Condition], [Available])
	VALUES ('HHAA212', 'FIAT', '500', 2020, 1, 3, NULL, 'Very good', 'true'),
	('HHAB215', 'Renault', 'Zoe', 2019, 2, 5, NULL, 'Excellent', 'false'),
	('HHAC218', 'Mercedes-Benz', 'E-Class Combi', 2016, 3, 5, NULL, 'Excellent', 'true')

CREATE TABLE [Employees](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL, 
	[FirstName] NVARCHAR(50) NOT NULL, 
	[LastName] NVARCHAR(50) NOT NULL, 
	[Title] NVARCHAR(50) NOT NULL, 
	[Notes] NVARCHAR(MAX)
)

INSERT INTO [Employees] ([FirstName], [LastName], [Title], [Notes])
	VALUES ('Jonathan', 'Hilbert', 'Manager', NULL),
	('Kristin', 'Pudenz', 'Customer service assistant', NULL),
	('Ricarda', 'Funk', 'Customer service assistant', NULL)

CREATE TABLE [Customers](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL, 
	[DriverLicenceNumber] VARCHAR(20) UNIQUE NOT NULL, 
	[FullName] NVARCHAR(80) NOT NULL, 
	[Address] NVARCHAR(80) NOT NULL, 
	[City] NVARCHAR(50) NOT NULL,
	[ZIPCode] VARCHAR(10) NOT NULL,
	[Notes] NVARCHAR(MAX)
)

INSERT INTO [Customers] ([DriverLicenceNumber], [FullName], [Address], [City], [ZIPCode])
	VALUES ('B575JK94L74', 'Andrea Herzog', 'Rote Gasse 42', 'Meißen', '01662'),
	('B072RRE2I55', 'Lea-Sophie Friedrich', 'Ernst-Thälmann-Straße', 'Dassow', '23942'),
	('B233IID8A43', 'Pauline Sophie Grabosch ', 'Im Elbbahnhof 49', 'Magdeburg', '39104')

CREATE TABLE [RentalOrders](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL, 
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL, 
	[CustomerId] INT FOREIGN KEY REFERENCES [Customers]([Id]) NOT NULL, 
	[CarId] INT FOREIGN KEY REFERENCES [Cars]([Id]) NOT NULL, 
	[TankLevel] TINYINT NOT NULL,
	[KilometrageStart] INT CHECK ([KilometrageStart] >= 0) NOT NULL,
	[KilometrageEnd] INT CHECK ([KilometrageEnd] > 0) NOT NULL,
	[TotalKilometrage] AS [KilometrageEnd] - [KilometrageStart],
	[StartDate] SMALLDATETIME NOT NULL,
	[EndDate] SMALLDATETIME NOT NULL,
	[TotalDays] AS DATEDIFF(DAY, [StartDate], [EndDate]),
	[RateApplied] DECIMAL(6,2) NOT NULL, -- Car => Category, TotalDays => Rate
	[TaxRate] AS [RateApplied] * 0.2,
	[OrderStatus] VARCHAR(20), 
	[Notes] NVARCHAR(MAX)
)

INSERT INTO [RentalOrders] ([EmployeeId], [CustomerId], [CarId], [TankLevel],
[KilometrageStart], [KilometrageEnd], [StartDate], [EndDate], [RateApplied], [OrderStatus])
	VALUES (2, 1, 3, 39, 12065, 12759, '2021-07-17', '2021-07-18', 330.34,'PaymentDue'),
	(2, 3, 1, 26, 22365, 22632, '2021-07-12', '2021-07-13', 128.73,'Completed'),
	(3, 2, 1, 23, 27125, 30744, '2021-07-10', '2021-08-10', 1240.03,'Processing')
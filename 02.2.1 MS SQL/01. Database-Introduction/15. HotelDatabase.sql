--CREATE DATABASE Hotel

--USE Hotel

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL, 
	LastName NVARCHAR(50) NOT NULL, 
	Title NVARCHAR(50) NOT NULL, 
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName, Title)
	VALUES ('Emily', 'Armstrong', 'Manager'),
	('Andrée-Anne', 'Côté', 'Receptionist'),
	('Stephanie', 'Barrett', 'Housemaid') 

CREATE TABLE Customers (
	AccountNumber INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL, 
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(20),
	EmergencyName NVARCHAR(50),
	EmergencyNumber VARCHAR(20),
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers (FirstName, LastName, PhoneNumber)
	VALUES ('Michelle', 'Li', '+1 368-204-2620'),
	('Rachel', 'Honderich', '+1 226-578-6151'),
	('Joshua', 'Hurlburt-Yu', '+1 204-201-2186')

CREATE TABLE RoomStatus (
	RoomStatus VARCHAR(30) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomStatus (RoomStatus, Notes)
	VALUES ('Do not disturb', 'The guest has requested not to be disturbed.'),
	('Occupied', 'A guest is currently occupied in the room.'),
	('Cleaning in progress', 'Room attendant is currently cleaning this room.')

CREATE TABLE RoomTypes (
	RoomType VARCHAR(30) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomTypes (RoomType, Notes)
	VALUES ('Single', 'A room assigned to one person. May have one or more beds.'),
	('Suite', 'A room with one or more bedrooms and a separate living space.'),
	('Cabana', 'This type of room is always adjoining to the swimming pool or have a private pool attached to the room.')

CREATE TABLE BedTypes (
	BedType VARCHAR(30) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)

INSERT INTO BedTypes (BedType)
	VALUES ('king-sized'),
	('queen-sized'),
	('twin')

CREATE TABLE Rooms (
	RoomNumber VARCHAR(5) PRIMARY KEY,
	RoomType VARCHAR(30) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType VARCHAR(30) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate DECIMAL(7,2) CHECK(Rate >= 0.0) NOT NULL,
	RoomStatus VARCHAR(30) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
	Notes NVARCHAR(MAX)
)

INSERT INTO Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus)
	VALUES ('A-102', 'Single', NULL, 75.50, 'Cleaning in progress'),
	('A-315', 'Suite', 'king-sized', 395.00, 'Occupied'),
	('B-005', 'Cabana', 'queen-sized', 220.00, 'Do not disturb')

CREATE TABLE Payments (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	PaymentDate DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	FirstDateOccupied DATE NOT NULL,
	LastDateOccupied DATE NOT NULL,
	TotalDays AS DATEDIFF(DAY, FirstDateOccupied, LastDateOccupied),
	AmountCharged DECIMAL(10,2) NOT NULL,
	TaxRate DECIMAL(5,2) NOT NULL,
	TaxAmount AS AmountCharged * TaxRate,
	PaymentTotal AS AmountCharged + (AmountCharged * TaxRate),
	Notes NVARCHAR(MAX)
)

INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, AmountCharged, TaxRate)
	VALUES (2, '2021-08-20', 1, '2021-08-25', '2021-08-26', 75.50, 0.2),
	(2, '2021-06-05', 2, '2021-06-03', '2021-06-04', 395.00, 0.2),
	(1, '2021-04-23', 3, '2021-04-23', '2021-04-25', 440.00, 0.2)

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL, 
	DateOccupied DATE NOT NULL, 
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL, 
	RoomNumber VARCHAR(5) FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL, 
	RateApplied DECIMAL(10,2) NOT NULL, 
	PhoneCharge DECIMAL(5,2) NOT NULL, 
	Notes NVARCHAR(MAX)
)

INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge)
	VALUES (2, '2021-08-25', 1, 'A-102', 75.50, 0),
	(2, '2021-06-03', 2, 'A-315', 395.00, 20.50),
	(1, '2021-04-23', 3, 'B-005', 220.00, 10.70)
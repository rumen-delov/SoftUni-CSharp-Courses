--CREATE DATABASE CigarShop

--USE CigarShop

--1

CREATE TABLE Addresses(
	Id INT PRIMARY KEY IDENTITY,
	Town VARCHAR(30) NOT NULL,
	Country NVARCHAR(30) NOT NULL,
	Streat NVARCHAR(100) NOT NULL,
	ZIP VARCHAR(20) NOT NULL
)

CREATE TABLE Clients(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id) NOT NULL
)

CREATE TABLE Sizes(
	Id INT PRIMARY KEY IDENTITY,
	[Length] INT CHECK([Length] BETWEEN 10 AND 25) NOT NULL,
	RingRange DECIMAL(4, 2) CHECK(RingRange BETWEEN 1.5 AND 7.5) NOT NULL	
)

CREATE TABLE Brands(
	Id INT PRIMARY KEY IDENTITY,
	BrandName VARCHAR(30) UNIQUE NOT NULL,
	BrandDescription VARCHAR(MAX)
)

CREATE TABLE Tastes(
	Id INT PRIMARY KEY IDENTITY,
	TasteType VARCHAR(20) NOT NULL,
	TasteStrength VARCHAR(15) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
)

CREATE TABLE Cigars(
	Id INT PRIMARY KEY IDENTITY,
	CigarName VARCHAR(80) NOT NULL,
	BrandId INT FOREIGN KEY REFERENCES Brands(Id) NOT NULL,
	TastId INT FOREIGN KEY REFERENCES Tastes(Id) NOT NULL,
	SizeId INT FOREIGN KEY REFERENCES Sizes(Id) NOT NULL,
	PriceForSingleCigar DECIMAL(7, 2) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
)

CREATE TABLE ClientsCigars(
	ClientId INT FOREIGN KEY REFERENCES Clients(Id) NOT NULL,
	CigarId INT FOREIGN KEY REFERENCES Cigars(Id) NOT NULL
	PRIMARY KEY(ClientId, CigarId)
)

--2 

INSERT INTO Cigars(CigarName, BrandId, TastId, SizeId, PriceForSingleCigar, ImageURL)
	VALUES ('COHIBA ROBUSTO', 9, 1, 5, 15.50, 'cohiba-robusto-stick_18.jpg'),
	('COHIBA SIGLO I', 9, 1, 10, 410.00, 'cohiba-siglo-i-stick_12.jpg'),
	('HOYO DE MONTERREY LE HOYO DU MAIRE', 14, 5, 11, 7.50, 'hoyo-du-maire-stick_17.jpg'),
	('HOYO DE MONTERREY LE HOYO DE SAN JUAN', 14, 4, 15, 32.00, 'hoyo-de-san-juan-stick_20.jpg'),
	('TRINIDAD COLONIALES',	2, 3, 8, 85.21, 'trinidad-coloniales-stick_30.jpg')

--SELECT * FROM Cigars

INSERT INTO Addresses(Town, Country, Streat, ZIP)
	VALUES ('Sofia', 'Bulgaria', '18 Bul. Vasil levski', '1000'),
		   ('Athens', 'Greece',	'4342 McDonald Avenue', '10435'),
		   ('Zagreb', 'Croatia', '4333 Lauren Drive', '10000')

--SELECT * FROM Addresses


--3

--SELECT * FROM Cigars
--SELECT * FROM Tastes

UPDATE Cigars
SET PriceForSingleCigar *= 1.20
WHERE TastId = (SELECT Id
				FROM Tastes 
				WHERE TasteType='Spicy')

--SELECT * FROM Cigars
--WHERE TastId = (SELECT Id
--				FROM Tastes 
--				WHERE TasteType='Spicy')

--SELECT * 
--FROM Cigars
--WHERE Id IN (SELECT c.Id
--FROM Cigars AS c, Tastes AS t
--WHERE c.TastId = t.Id AND t.TasteType='Spicy')

--SELECT *FROM Brands
--WHERE BrandDescription IS NULL

UPDATE Brands
SET BrandDescription = 'New description'
WHERE BrandDescription IS NULL


--4

--SELECT * FROM Addresses
--WHERE Country LIKE 'C%'


--SELECT * FROM Clients


DELETE FROM Clients
WHERE AddressId IN (7, 8, 10, 23)

DELETE FROM Addresses
WHERE Country LIKE 'C%'


--SELECT * FROM Clients
--WHERE AddressId IN (SELECT Id FROM Addresses WHERE Country LIKE 'C%')


-- 5
--USE master
--DROP DATABASE CigarShop

SELECT CigarName, PriceForSingleCigar, ImageURL
FROM Cigars
ORDER BY PriceForSingleCigar ASC, CigarName DESC

--6
--SELECT * FROM Cigars
--SELECT * FROM Tastes

SELECT c.Id, c.CigarName, c.PriceForSingleCigar, t.TasteType, t.TasteStrength 
FROM Cigars AS c, 
	 Tastes AS t
WHERE c.TastId = t.Id AND t.TasteType IN ('Earthy', 'Woody')
ORDER BY PriceForSingleCigar DESC

--7
SELECT * FROM Clients
SELECT * FROM ClientsCigars

SELECT c.Id,
	   CONCAT(c.FirstName, ' ', c.LastName) AS ClientName,
	   c.Email
FROM Clients AS c
LEFT JOIN ClientsCigars AS cc
	ON c.Id = cc.ClientId
WHERE cc.CigarId IS NULL
ORDER BY ClientName



--8
SELECT * FROM Cigars
SELECT * FROM Sizes
WHERE [Length] >= 12 

SELECT TOP(5) c.CigarName, c.PriceForSingleCigar, c.ImageURL
FROM Cigars AS c
JOIN Sizes AS s
	ON c.SizeId = s.Id
WHERE s.[Length] >= 12 AND (c.CigarName LIKE '%ci%' OR (c.PriceForSingleCigar > 50 AND s.RingRange > 2.55))
ORDER BY c.CigarName ASC, c.PriceForSingleCigar DESC


--9

SELECT * FROM Clients
SELECT * FROM Addresses
SELECT * FROM ClientsCigars
SELECT * FROM Cigars


SELECT CONCAT(c.FirstName, ' ', c.LastName) AS FullName,
	   a.Country,
	   a.ZIP,
	   CONCAT('$',MAX(cg.PriceForSingleCigar)) AS CigarPrice	   
FROM Clients AS c
JOIN Addresses AS a
	ON c.AddressId = a.Id
JOIN ClientsCigars AS cc
	ON c.Id = cc.ClientId
JOIN Cigars AS cg
	ON cc.CigarId = cg.Id
WHERE a.ZIP NOT LIKE '%[^0-9]%'  --ISNUMERIC(a.ZIP) = 1
GROUP BY c.FirstName, c.LastName, a.Country, a.ZIP
ORDER BY FullName ASC



--SELECT 
--    CONCAT(c.FirstName, ' ', c.LastName) AS FullName, 
--    a.Country, 
--    a.ZIP, 
--    CONCAT('$', MAX(cig.[PriceForSingleCigar])) AS [CigarPrice]
--FROM [Clients] AS c
--JOIN [Addresses] AS a 
--	ON a.[Id] = c.[AddressId]
--JOIN [ClientsCigars] AS cc 
--	ON cc.[ClientId] = c.[Id]
--JOIN [Cigars] AS cig 
--	ON cig.[Id] = cc.[CigarId]
--WHERE a.[ZIP] NOT LIKE '%[^0-9.]%'
--GROUP BY c.[FirstName], c.[LastName], a.[Country], a.[ZIP]


--SELECT 
--    CONCAT(cl.[FirstName], ' ', cl.[LastName]) AS [FullName], 
--    a.[Country], 
--    a.[ZIP], 
--    CONCAT('$', MAX(cig.[PriceForSingleCigar])) AS [CigarPrice]
--FROM [dbo].[Clients] AS cl
--JOIN [dbo].[Addresses] AS a 
--	ON a.[Id] = cl.[AddressId]
--JOIN [dbo].[ClientsCigars] AS cc 
--	ON cc.[ClientId] = cl.[Id]
--JOIN [dbo].[Cigars] AS cig 
--	ON cig.[Id] = cc.[CigarId]
--WHERE a.[ZIP] NOT LIKE '%[^0-9.]%'
--GROUP BY cl.[FirstName], cl.[LastName], a.[Country], a.[ZIP]


--10


SELECT * FROM Addresses

SELECT * FROM Clients
SELECT * FROM ClientsCigars
SELECT * FROM Cigars

SELECT c.LastName, 
	   AVG(s.Length) AS CigarLength,
	   CEILING(AVG(s.RingRange)) AS CigarRingRange
FROM Clients AS c 
JOIN ClientsCigars AS cc
	ON c.Id = cc.ClientId
JOIN Cigars AS cg
	ON cc.CigarId = cg.Id
JOIN Sizes AS s
	ON cg.SizeId = s.Id
GROUP BY c.LastName
ORDER BY CigarLength DESC

--SELECT cl.[LastName], AVG(s.[Length]) AS [CiagrLength], CEILING(AVG(s.[RingRange])) AS [CiagrRingRange]
--FROM [Clients] AS cl
--JOIN [ClientsCigars] AS cc 
--	ON cl.Id = cc.[ClientId]
--JOIN [Cigars] AS ci	
--	ON cc.[CigarId] = ci.[Id]
--JOIN [Sizes] AS s 
--	ON ci.[SizeId] = s.Id
--GROUP BY cl.[LastName]
--ORDER BY [CiagrLength] DESC

--11
GO

CREATE FUNCTION udf_ClientWithCigars(@Name NVARCHAR(30))
RETURNS INT
AS
BEGIN
    DECLARE @CigarCount INT = 
    (
        SELECT COUNT(cc.CigarId) 
		FROM Clients AS c
        JOIN ClientsCigars AS cc
			ON c.Id = cc.ClientId
        WHERE c.FirstName = @Name
    )
    RETURN @CigarCount
END

GO
SELECT dbo.udf_ClientWithCigars('Betty') 

--12

--SELECT * FROM Cigars
--SELECT * FROM Tastes

GO

CREATE PROC usp_SearchByTaste(@taste VARCHAR(20))
AS
SELECT cg.CigarName,
	   CONCAT('$', cg.PriceForSingleCigar) AS Price,
	   t.TasteType,
	   b.BrandName,
	   CONCAT(s.[Length],' cm') AS CigarLength,
	   CONCAT(s.RingRange, ' cm') AS CigarRingRange
FROM Cigars AS cg
JOIN Tastes AS t
	ON cg.TastId = t.Id
JOIN Sizes AS s
	ON s.Id = cg.SizeId
JOIN Brands AS b
	ON b.Id = cg.BrandId
WHERE t.TasteType = @taste
ORDER BY CigarLength ASC, CigarRingRange DESC

GO

EXEC usp_SearchByTaste 'Woody'
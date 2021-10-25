--USE [SoftUni]

SELECT FirstName, LastName  
FROM Employees
WHERE LEFT(FirstName, 2) = 'Sa'

-- or

--SELECT [FirstName], [LastName] 
--FROM [Employees]
--WHERE SUBSTRING([FirstName], 1, 2) = 'Sa'

-- or

--SELECT [Firstname], [LastName] 
--FROM [Employees]
--WHERE [FirstName] LIKE 'Sa%'



--2

SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE [LastName] LIKE '%ei%'

-- or

--SELECT [FirstName], [LastName], CHARINDEX('ei', [LastName]) FROM [Employees]

-- or

--SELECT [FirstName], [LastName] FROM [Employees]
--WHERE CHARINDEX('ei', [LastName]) <> 0

-- or

--SELECT FirstName, LastName FROM Employees
--WHERE NOT CHARINDEX('ei', LastName) = 0



-- 3

SELECT [FirstName] 
FROM [Employees]
WHERE [DepartmentID] = 3 OR [DepartmentID] = 10 AND YEAR([HireDate]) BETWEEN 1995 AND 2005

-- or

SELECT FirstName FROM Employees
WHERE DepartmentID IN(3, 10) AND DATEPART(YEAR, HireDate) BETWEEN 1995 AND 2005



--4

SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE [JobTitle] NOT LIKE '%engineer%'



--5

SELECT [Name] 
FROM [Towns]
WHERE LEN([Name]) IN(5, 6)
ORDER BY [Name]



--6

SELECT [TownID], [Name] 
FROM [Towns]
WHERE [Name] LIKE '[MKBE]%'
ORDER BY [Name]


-- or

--SELECT [TownID], [Name] 
--FROM [Towns]
--WHERE LEFT([Name], 1) IN ('M', 'K', 'B','E')
--ORDER BY [Name]

-- or

--SELECT [TownID], [Name] 
--FROM [Towns]
--WHERE SUBSTRING([Name], 1, 1) IN ('M', 'K', 'B','E')
--ORDER BY [Name]



--7

SELECT [TownID], [Name] 
FROM [Towns]
WHERE [Name] LIKE '[^RBD]%'
ORDER BY [Name]

--or

--SELECT [TownID], [Name] 
--FROM [Towns]
--WHERE [Name] NOT LIKE '[RBD]%'
--ORDER BY [Name]

-- or

--SELECT [TownID], [Name] 
--FROM [Towns]
--WHERE LEFT([Name], 1) NOT IN ('R', 'B', 'D')
--ORDER BY [Name]

-- or

--SELECT [TownID], [Name] 
--FROM [Towns]
--WHERE SUBSTRING([Name], 1, 1) NOT IN ('R', 'B', 'D')
--ORDER BY [Name]



--8
GO

CREATE VIEW [V_EmployeesHiredAfter2000]
AS
SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE YEAR([HireDate]) > 2000  -- or  WHERE DATEPART(YEAR, HireDate) > 2000

GO



--9

SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE LEN([LastName]) = 5 -- or WHERE LEN([LastName]) IN (5) 




--10

SELECT [EmployeeID] , [FirstName], [LastName], [Salary],
	DENSE_RANK() 
	OVER (PARTITION BY [Salary] 
		  ORDER BY [EmployeeID]) 
	AS [Rank]
FROM [Employees]
WHERE [Salary] BETWEEN 10000 AND 50000
ORDER BY [Salary] DESC



--11

SELECT *
FROM 
	(
	SELECT [EmployeeID] , [FirstName], [LastName], [Salary],
		DENSE_RANK() 
		OVER (PARTITION BY [Salary] 
			ORDER BY [EmployeeID]) 
		AS [Rank]
	FROM [Employees]
	WHERE [Salary] BETWEEN 10000 AND 50000
	)
AS [RankingTable]
WHERE [Rank] = 2 
ORDER BY [Salary] DESC



--12
--USE [Geography]
--GO

SELECT [CountryName] AS [Country Name],
	   [ISOCode] AS [ISO Code]
FROM [Countries] 
WHERE  [CountryName] LIKE ('%A%A%A%')
ORDER BY [ISOCode] 



--13
--USE [Geography]
--GO

SELECT p.[PeakName], 
	   r.[RiverName],
	   LOWER(CONCAT(LEFT(p.[PeakName], LEN(p.[PeakName]) - 1), r.[RiverName])) AS [Mix] 
FROM [Peaks] AS p, [Rivers] AS r
WHERE LOWER(RIGHT(p.[PeakName], 1)) = LOWER(LEFT(r.[RiverName], 1))
ORDER BY [Mix]



--14
--USE [Diablo]
--GO
 
--SELECT *
--FROM [Games]

SELECT TOP(50) [Name], FORMAT([Start], 'yyyy-MM-dd') AS [Start]
FROM [Games]
WHERE YEAR([Start]) BETWEEN 2011 AND 2012
ORDER BY [Start], [Name]



--15

SELECT [Username], 
		SUBSTRING([Email], CHARINDEX('@',[Email]) + 1, LEN([Email]) - CHARINDEX('@',[Email])) AS [Email Provider]
FROM [Users]
ORDER BY [Email Provider], [Username]



--16

SELECT [Username], [IPAddress] AS [IP Address]
FROM [Users]
WHERE [IPAddress] LIKE '___.1_%._%.___' 
ORDER BY [Username]



--17

--SELECT *
--FROM [Games]
--ORDER BY Name

SELECT [Name] AS [Game], 
			CASE
				WHEN DATEPART(HOUR, [Start]) >= 0 AND DATEPART(HOUR, [Start]) < 12 THEN 'Morning'
				WHEN DATEPART(HOUR, [Start]) >= 12 AND DATEPART(HOUR, [Start]) < 18 THEN 'Afternoon'
				ELSE 'Evening'
			END
			AS [Part of the Day],
			CASE
				WHEN [Duration] <= 3 THEN 'Extra Short'
				WHEN [Duration] BETWEEN 4 AND 6 THEN 'Short'
				WHEN [Duration] > 6 THEN 'Long'
				ELSE 'Extra Long'
			END
			AS [Duration]
FROM [Games]
ORDER BY [Game], [Duration], [Part of the Day]



--18
--USE [Orders]
--GO

--SELECT *
--FROM Orders

SELECT [ProductName],
	   [OrderDate],
	   DATEADD(DAY, 3, [OrderDate]) AS [Pay Due],
	   DATEADD(MONTH, 1, [OrderDate]) AS [Deliver Due]
FROM [Orders]


--19

--USE [Test]

CREATE TABLE [People](
	[Id] INT IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	[BirthDate] DATETIME NOT NULL
)

INSERT INTO [People]([Name], [Birthdate])
VALUES ('Victor', '2000-12-07 00:00:00.000'),
	   ('Steven', '1992-09-10 00:00:00.000'),
	   ('Stephen', '1910-09-19 00:00:00.000'),
	   ('John', '2010-01-06 00:00:00.000')

SELECT [Name],
	    DATEDIFF(YEAR, [BirthDate], GETDATE()) AS [Age in Years],
		DATEDIFF(MONTH, [BirthDate], GETDATE()) AS [Age in Months],
		DATEDIFF(DAY, [BirthDate], GETDATE()) AS [Age in Days],
		DATEDIFF(MINUTE, [BirthDate], GETDATE()) AS [Age in Minutes]
FROM [People]


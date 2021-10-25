USE [SoftUni]

-- Problem 4
SELECT [FirstName]
	 , [LastName]
	 , [Salary] 
  FROM [Employees]

-- Problem 5
SELECT [FirstName]
	 , [MiddleName] 
	 , [LastName] 
  FROM [Employees]

-- Problem 6
SELECT [FirstName] + '.' +  [LastName] + '@' + 'softuni.bg'
	AS [Full Email Address] 
  FROM [Employees]
-- or
SELECT CONCAT([FirstName], '.', [LastName], '@', 'softuni.bg') 
	AS [Full Email Address] 
  FROM [Employees]

-- Problem 7
SELECT DISTINCT [Salary] 
		   FROM [Employees]

-- Problem 9
SELECT [FirstName]
	 , [LastName]
	 , [JobTitle]
  FROM [Employees]
 WHERE [Salary] BETWEEN 20000 AND 30000

 -- Problem 10
SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName])
	AS [FullName]
  FROM [Employees]
 WHERE [Salary] IN (25000, 14000, 12500, 23600)
 -- or
 --WHERE [Salary] = 25000 OR [Salary] = 14000 OR [Salary] = 12500 OR [Salary] = 23600

 -- or
 -- Do not use CONCAT_WS in JUDGE because it is a new function!
SELECT CONCAT_WS(' ', [FirstName], [MiddleName], [LastName]) AS [FullName]
  FROM [Employees]
 WHERE [Salary] IN (25000, 14000, 12500, 23600)

-- Problem 11
SELECT [FirstName], [LastName]
  FROM [Employees]
 WHERE [ManagerID] IS NULL

-- Problem 12
   SELECT [FirstName], [LastName], [Salary]
     FROM [Employees]
    WHERE [Salary] > 50000
 ORDER BY [Salary] DESC

-- Problem 13
   SELECT TOP(5) [FirstName], [LastName]
     FROM [Employees]
 ORDER BY [Salary] DESC

-- Problem 15
   SELECT *
     FROM [Employees]
 ORDER BY [Salary] DESC, [FirstName], [LastName] DESC, [MiddleName]
--ORDER BY [Salary] DESC, [FirstName]ASC, [LastName] DESC, [MiddleName]ASC

-- Problem 17
GO

CREATE VIEW [V_EmployeeNameJobTitle] AS (
     SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName]) AS [Full Name],
	        [JobTitle] AS [Job Title]
       FROM [Employees])

--CREATE VIEW [V_EmployeeNameJobTitle] AS (
--     SELECT CONCAT([FirstName], ' ', ISNULL([MiddleName], ''), ' ', [LastName]) AS [Full Name],
--	        [JobTitle] AS [Job Title]
--       FROM [Employees])

GO

-- Problem 21
UPDATE [Employees]
   SET [Salary] += [Salary] * 0.12
 WHERE [DepartmentID] IN (1, 2, 4, 11)

SELECT [Salary]
  FROM [Employees]

-- RESTORE THE DB (Delete the DB and load it again from the file)

-- Problem 24
USE [Geography]

  SELECT [CountryName], [CountryCode],
		 CASE
		    WHEN [CurrencyCode] = 'EUR' THEN 'Euro'
			ELSE 'Not Euro'
         END AS [Currency]
    FROM [Countries]
ORDER BY [CountryName]

--USE [SoftUni]

SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE [LastName] LIKE '%ei%'

/* This query shows that the CHARINDEX function returns 0 if 
   there is no match found to the specific pattern */
--SELECT [FirstName], [LastName], CHARINDEX('ei', [LastName]) AS [Start Index Containing 'ei'] 
--FROM [Employees]

-- or

SELECT [FirstName], [LastName] 
FROM [Employees]
WHERE CHARINDEX('ei', [LastName]) <> 0

-- or

SELECT [FirstName], [LastName] 
FROM [Employees]
WHERE NOT CHARINDEX('ei', [LastName]) = 0
--USE [SoftUni]

SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE [JobTitle] NOT LIKE '%engineer%'

-- or

SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE CHARINDEX('engineer', [JobTitle]) = 0
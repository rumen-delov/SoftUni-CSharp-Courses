--USE [SoftUni]

SELECT [FirstName], [LastName]  
FROM [Employees]
WHERE LEFT([FirstName], 2) = 'Sa' -- LEFT(String, Count)

-- or

SELECT [FirstName], [LastName] 
FROM [Employees]
WHERE SUBSTRING([FirstName], 1, 2) = 'Sa' -- SUBSTRING(String, StartIndex, Length)

-- or

SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE [FirstName] LIKE 'Sa%'
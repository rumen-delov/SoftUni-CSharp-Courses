--USE [SoftUni]

SELECT [Firstname], [LastName] 
FROM [Employees]
WHERE LEN([LastName]) = 5 
--    LEN([LastName]) IN (5)
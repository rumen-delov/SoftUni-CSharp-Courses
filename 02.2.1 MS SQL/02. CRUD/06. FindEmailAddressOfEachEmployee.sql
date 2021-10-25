--USE [SoftUni]

SELECT [FirstName] + '.' + [LastName] + '@softuni.bg' AS [Full Email Address]
FROM [Employees]

-- or

--SELECT CONCAT([FirstName], '.', [LastName], '@softuni.bg') AS [Full Email Address]
--FROM [Employees]

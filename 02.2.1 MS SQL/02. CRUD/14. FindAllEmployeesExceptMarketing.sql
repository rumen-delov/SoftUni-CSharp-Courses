--USE [SoftUni]

SELECT [FirstName], [LastName]
FROM [Employees]
WHERE [DepartmentID] <> 4

-- or

--SELECT [FirstName], [LastName]
--FROM [Employees]
--WHERE [DepartmentID] != 4

-- or

--SELECT [FirstName], [LastName]
--FROM [Employees]
--WHERE  NOT ([DepartmentID] = 4) 
--USE [SoftUni]

SELECT [FirstName] 
FROM [Employees]
WHERE [DepartmentID] = 3 OR [DepartmentID] = 10 
      AND YEAR([HireDate]) BETWEEN 1995 AND 2005

-- or

SELECT [FirstName] 
FROM [Employees]
WHERE [DepartmentID] IN(3, 10) 
      AND DATEPART(YEAR, [HireDate]) BETWEEN 1995 AND 2005
--        DATEPART(YYYY, [HireDate])
--        DATEPART(YY, [HireDate]) 
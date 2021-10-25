USE SoftUni

SELECT * FROM Employees
SELECT * FROM EmployeesProjects


---Task 05: Employees Without Projects
SELECT TOP(3) e.[EmployeeID],
              e.[FirstName]
         FROM [Employees] AS e
         LEFT JOIN [EmployeesProjects] AS ep 
           ON e.[EmployeeID] = ep.[EmployeeID]
        WHERE ep.[EmployeeID] IS NULL 
        ORDER BY e.[EmployeeID]

--8

SELECT e.[EmployeeID], 
	   e.[FirstName],
	   CASE
			WHEN YEAR(p.[StartDate]) >= 2005 THEN NULL
			ELSE p.[Name] 
	   END 
       AS [ProjectName]
FROM [Employees] AS e
INNER JOIN [EmployeesProjects] AS ep
	ON e.[EmployeeID] = ep.[EmployeeID]
INNER JOIN [Projects] AS p
	ON ep.[ProjectID] = p.[ProjectID]
WHERE e.[EmployeeID] = 24



--10
SELECT TOP(50) e.[EmployeeID],
               CONCAT(e.[FirstName], ' ', e.[LastName]) AS [EmployeeName],
               CONCAT(em.[FirstName], ' ', em.[LastName]) AS [ManagerName],
               d.[Name] AS [DepartmentName]
FROM [Employees] AS e 
INNER JOIN [Employees] AS em 
	ON e.[ManagerID] = em.[EmployeeID]
INNER JOIN [Departments] AS d 
	ON e.[DepartmentID] = d.[DepartmentID]    
ORDER BY e.[EmployeeID]

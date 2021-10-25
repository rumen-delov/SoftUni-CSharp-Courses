--USE [SoftUni]

--BACKUP DATABASE [SoftUni] 
--TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SoftUni.bak'

/* Check the DepartmentIDs of Engineering, Tool Design, Marketing, or Information Services departments 
   to use it in the update */
--SELECT * 
--FROM [Departments]

UPDATE [Employees]
SET [Salary] += [Salary] * 0.12 
WHERE [DepartmentID] IN (1, 2, 4, 11)

SELECT [Salary] 
FROM [Employees]

--USE [master]
--GO

--DROP DATABASE [SoftUni]
--GO

--RESTORE DATABASE [SoftUni] 
--FROM DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SoftUni.bak'
--GO

--USE [SoftUni]
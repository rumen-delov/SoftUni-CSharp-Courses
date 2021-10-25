--USE [SoftUni]

CREATE VIEW [V_EmployeeNameJobTitle]
AS
SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName]) AS [Full Name]
	 , [JobTitle] AS [Job Title]
FROM [Employees]

-- or

--CREATE VIEW [V_EmployeeNameJobTitle] 
--AS
--SELECT CONCAT([FirstName], ' ', ISNULL([MiddleName], ''), ' ', [LastName]) AS [Full Name]
--	   , [JobTitle] AS [Job Title]
--FROM [Employees]

-- using the view
--SELECT * FROM [V_EmployeeNameJobTitle] 
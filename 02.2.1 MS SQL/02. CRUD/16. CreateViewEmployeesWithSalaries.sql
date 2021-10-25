--USE [SoftUni]

CREATE VIEW [V_EmployeesSalaries] 
AS
SELECT [FirstName], [LastName], [Salary] 
FROM Employees

-- using the view
--SELECT * FROM [V_EmployeesSalaries]
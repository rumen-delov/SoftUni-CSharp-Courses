--USE [SoftUni]

SELECT TOP(10) *
FROM [Projects]
WHERE [StartDate] IS NOT NULL
ORDER BY [StartDate]
	   , [Name]

-- or ?

--SELECT TOP(10) *
--FROM [Projects]
--ORDER BY [StartDate]
--	   , [Name]
USE [SoftUni]

SELECT [TownID], [Name] 
FROM [Towns]
WHERE [Name] LIKE '[^RBD]%'
ORDER BY [Name]

--or

SELECT [TownID], [Name] 
FROM [Towns]
WHERE [Name] NOT LIKE '[RBD]%'
ORDER BY [Name]

-- or

SELECT [TownID], [Name] 
FROM [Towns]
WHERE LEFT([Name], 1) NOT IN ('R', 'B', 'D')
ORDER BY [Name]

-- or

SELECT [TownID], [Name] 
FROM [Towns]
WHERE SUBSTRING([Name], 1, 1) NOT IN ('R', 'B', 'D')
ORDER BY [Name]
--USE [Diablo]

SELECT [Username], 
       [IPAddress] AS [IP Address]
FROM [Users]
WHERE [IPAddress] LIKE '___.1_%._%.___' 
ORDER BY [Username]

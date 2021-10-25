--USE [Geography]

--SELECT * FROM [Mountains]
--SELECT * FROM [Peaks]

SELECT m.[MountainRange], p.[PeakName], p.[Elevation] 
FROM [Mountains] AS m, [Peaks] AS p
WHERE p.[MountainId] = m.[Id] AND m.[MountainRange] = 'Rila' -- m.[Id]=17
ORDER BY p.[Elevation] DESC

-- or

--SELECT m.[MountainRange], p.[PeakName], p.[Elevation] 
--FROM [Mountains] AS m
--JOIN [Peaks] AS p 
--	ON p.[MountainId] = m.[Id]
--WHERE m.[MountainRange] = 'Rila'
--ORDER BY p.[Elevation] DESC
--USE [Hotel]

UPDATE [Payments]
SET [TaxRate] -= [TaxRate] * 0.03

SELECT [TaxRate] 
FROM [Payments]

-- or
--UPDATE [Payments]
--SET [TaxRate] = [TaxRate] * 0.97

--SELECT [TaxRate] 
--FROM [Payments]
USE [Minions]

-- The string values TRUE and FALSE can be converted to bit values: 
-- TRUE is converted to 1 and FALSE is converted to 0.
-- Converting to bit promotes any nonzero value to 1.
-- https://docs.microsoft.com/en-us/sql/t-sql/data-types/bit-transact-sql?redirectedfrom=MSDN&view=sql-server-ver15

CREATE TABLE [Users](
	[Id] BIGINT PRIMARY KEY IDENTITY NOT NULL,
	[Username] VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	[ProfilePicture] VARBINARY(MAX),
	[LastLoginTime] DATETIME2 NOT NULL,
	[IsDeleted] BIT DEFAULT 'false' NOT NULL
)

INSERT INTO [Users]([Username], [Password], [ProfilePicture], [LastLoginTime], [IsDeleted]) 
	VALUES	('stamo_p', 'CSharp-DB21$', NULL, '2021-09-18 19:42:31', 'false'),
			('nik.k', 'SoFt_Un1', NULL, '2021-08-23 06:12:13', 'true'),
			('svetlinnakov01', '21%C#', NULL, '2021-06-02 10:15:23', 'false'),
			('i.kenov', 'codeItUp21!', NULL, '2021-04-22 08:52:53', 'true'),
			('ines-ivanova', 'c0deW1thF1ne55e', NULL, '2021-08-28 12:32:55', 'true')
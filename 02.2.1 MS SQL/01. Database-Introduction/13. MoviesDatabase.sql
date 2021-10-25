--CREATE DATABASE [Movies]

--USE [Movies]

CREATE TABLE [Directors](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[DirectorName] NVARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(MAX)
)

CREATE TABLE [Genres](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[GenreName] VARCHAR(50) UNIQUE NOT NULL,
	[Notes] NVARCHAR(MAX)
)
 
CREATE TABLE [Categories](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[CategoryName] VARCHAR(50) UNIQUE NOT NULL,
	[Notes] NVARCHAR(MAX)
)

CREATE TABLE [Movies](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Title] NVARCHAR(80) NOT NULL,
	[DirectorId] INT FOREIGN KEY REFERENCES [Directors]([Id]),
	[CopyrightYear] DATE NOT NULL,
	[Length] INT NOT NULL, -- in minutes
	[GenreId] INT FOREIGN KEY REFERENCES [Genres]([Id]),
	[CategoryId] INT FOREIGN KEY REFERENCES [Categories]([Id]),
	[Rating] DECIMAL(3,1) CHECK ([Rating] >= 0 AND [Rating] <= 10),
	[Notes] NVARCHAR(MAX)
)

-- Change a column to NULL
--ALTER TABLE [Movies]
--ALTER COLUMN [CategoryId] INT NULL

INSERT INTO [Directors]([DirectorName], [Notes]) 
	VALUES ('Steven Spielberg', 'Known for "Jurassic Park", "E.T. the Extra-Terrestrial", "Schindler''s List", "Indiana Jones and the Last Crusade"'),
	('Martin Scorsese', 'Known for "Goodfellas", "Taxi Driver", "The Wolf of Wall Street"'),
	('Quentin Tarantino', 'Known for "Pulp Fiction", "Inglourious Basterds", "Reservoir Dogs"'),
	('Ridley Scott', 'Known for "Gladiator", "A Good Year"'),
	('Francis Ford Coppola', 'Known for "The Godfather"')

INSERT INTO [Genres]([GenreName], [Notes]) 
	VALUES ('Adventure', 'Adventure films are usually exciting stories, with new experiences or exotic locales.'),
	('Crime', 'Crime films are developed around the sinister actions of criminals.'),
	('Comedy', 'Comedies are light-hearted plots consistently and deliberately designed to amuse and provoke laughter.'),
	('Drama', 'Dramas are serious, plot-driven presentations, portraying realistic characters, settings, life situations, and stories involving intense character development and interaction.'),
	('Fantasy', 'Fantasy films are defined by situations that transcend natural laws and/or by settings inside a fictional universe.')

INSERT INTO [Categories]([CategoryName], [Notes])
	VALUES ('G ', 'General Audience films are meant to be viewable by all ages.'),
	('PG ', 'Parental Guidance movies could contain mild profanity or violence, or even brief nudity.'),
	('PG-13', 'Parental Guidance - 13 was created to give an alternative to rating any movie that was not “kid friendly” an R rating.'),
	('R', 'Restricted movies contain adult themes in abundance.'),
	('NC-17', 'Restricted - 17 movies are considered too adult in nature for any children to see.')

INSERT INTO [Movies]([Title], [DirectorId], [CopyrightYear], [Length], [GenreId], [CategoryId], [Rating], [Notes])
	VALUES ('No Time to Die', NULL, '2021-09-28', 163, NULL, 3, NULL, 'It is the 25th film in the James Bond series.'),
	('Goodfellas', 2, '1990-09-19', 146, 2, 4, 8.7, 'The film narrates the rise and fall of mob associate Henry Hill and his friends and family from 1955 to 1980'),
	('The Godfather', 5, '1972-03-24', 177, 4, 4, 9.2, 'The story, spanning from 1945 to 1955, chronicles the Corleone family under patriarch Vito Corleone (Brando), focusing on the transformation of his youngest son, Michael Corleone (Pacino), from reluctant family outsider to ruthless mafia boss.'),
	('Gladiator', 4, '2000-05-05', 155, NULL, 4, 8.5, 'Russel Crowe portrays Roman general Maximus Decimus Meridius, who is betrayed when Commodus, the ambitious son of Emperor Marcus Aurelius, murders his father and seizes the throne. Reduced to slavery, Maximus becomes a gladiator and rises through the ranks of the arena to avenge the murders of his family and his emperor.'),
	('Inglourious Basterds', 3, '2009-08-21', 153, NULL, 4, 8.3, 'Starring	Brad Pitt, Christoph Waltz, Michael Fassbender.')
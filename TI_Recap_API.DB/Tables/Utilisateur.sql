﻿CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY,
	[Nom] VARCHAR(50) NOT NULL,
	[Prenom] VARCHAR(50) NOT NULL,
	[Email] VARCHAR(100) NOT NULL,
	[Password] VARCHAR(MAX) NOT NULL,
	CONSTRAINT UK_Email UNIQUE ([Email]),
	CONSTRAINT CK_Password CHECK (LEN([Password]) >= 8)

)

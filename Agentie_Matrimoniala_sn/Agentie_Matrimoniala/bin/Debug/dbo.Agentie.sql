CREATE TABLE [dbo].[Agentie]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] VARCHAR(20) NULL, 
    [Prenume] VARCHAR(20) NULL, 
    [Varsta] INT NULL, 
    [Sex] VARCHAR(1) NULL, 
    [Ocupatie] VARCHAR(255) NULL
)

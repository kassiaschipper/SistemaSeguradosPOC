CREATE TABLE [dbo].[Insured]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Nome] VARCHAR (100) NOT NULL,
	[Cpf] Varchar (11) NOT NULL UNIQUE,
	[DataNascimento] DATE NOT NULL,
)

CREATE TABLE [dbo].[Segurados]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Nome] VARCHAR (100) NOT NULL,
	[Cpf] Varchar (11) NOT NULL UNIQUE,
	[Email] Varchar (50) NOT NULL UNIQUE,
	[DataNascimento] DATE NOT NULL,
	[ValorContribuicao] DECIMAL (10, 2) NOT NULL
)

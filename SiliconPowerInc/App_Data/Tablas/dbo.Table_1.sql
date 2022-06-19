CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY UNIQUE,
	[Name] nvarchar(255) NULL,
	[SurName] nvarchar(255) NULL,
	[Mail] nvarchar(255) NOT NULL Unique,
	[Pswrd] nvarchar(255) NOT NULL,
	[Direccion] nvarchar(255) NULL,
	[Poblacion] nvarchar(255) NULL,
	[CP] INT NULL,
	[Pais] nvarchar(255) NULL,
	[Latitud] nvarchar(255) NULL,
	[Longitud] nvarchar(255) NULL,
)
CREATE TABLE [dbo].[USER_DPS]
(
	[Id_matricula] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[senha] [varchar](250) NOT NULL,
	[setor] [varchar](50) NOT NULL,
	[a-cadastro] [int] NULL,
	[a-import] [int] NULL,
	[a-embalagem] [int] NULL,
	[a-consulta] [int] NULL,
	[a-op] [int] NULL,
	[a-adm] [int] NULL,
	[status_user] [int] NULL, 
    CONSTRAINT [PK_USER_DPS] PRIMARY KEY ([Id_matricula]),
)

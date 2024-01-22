CREATE TABLE [dbo].[C_DOWNTIME_DPS]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[data] [date] NULL,
	[data_hora] [datetime] NULL,
	[linha] [varchar](20) NULL,
	[turno] [int] NULL,
	[duracao] [varchar](30) NULL,
	[id_downtime] [int] NULL,
	[tipo_categoria] [varchar](50) NULL,
	[descricao] [varchar](300) NULL,
	[status] [varchar](50) NULL,
	[data_horaF] [datetime] NULL,
	[duracaoM] [time](7) NULL,
	[setor] [varchar](50) NULL,
	[pausa] [varchar](50) NULL,
	[id_user] [int] NULL
)

CREATE TABLE [dbo].[Embalagem]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [varchar](50) NULL,
	[sn] [varchar](21) NULL,
	[id_modelo] [int] NULL,
	[id_ckd_fk] [varchar](20) NULL,
	[id_user] [int] NULL,
	[data] [date] NULL,
	[data_hora] [datetime] NULL,
	[filial] [int] NULL,
	[d_e_l_e_t_e] [int] NULL,
	[linha] [varchar](50) NULL, 
    CONSTRAINT [FK_Embalagem_ToMODELO] FOREIGN KEY ([id_modelo]) REFERENCES MODELO_DPS([Id_modelo_PK]), 
    CONSTRAINT [FK_Embalagem_ToCKD] FOREIGN KEY ([id_ckd_fk]) REFERENCES CKD_DPS([CKD_PK]), 
    CONSTRAINT [FK_Embalagem_ToUSER] FOREIGN KEY ([id_user]) REFERENCES USER_DPS([Id_matricula]),
)

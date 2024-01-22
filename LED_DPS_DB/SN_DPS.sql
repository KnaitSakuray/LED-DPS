CREATE TABLE [dbo].[SN_DPS]
(
	[sn] VARCHAR(21) NOT NULL, 
    [data] DATE NOT NULL,
    [data_hora] DATETIME NOT NULL,
    [id_modelo] INT NOT NULL, 
    [id_ckd_fk] VARCHAR(20) NOT NULL, 
    [filial] INT NOT NULL, 
     
    CONSTRAINT [PK_SN_DPS] PRIMARY KEY ([sn]), 
    CONSTRAINT [FK_SN_DPS_To_CKD] FOREIGN KEY ([id_ckd_fk]) REFERENCES CKD_DPS([CKD_PK]), 
    CONSTRAINT [FK_SN_DPS_To_MODELO] FOREIGN KEY ([id_modelo]) REFERENCES MODELO_DPS([Id_modelo_PK]) 
)

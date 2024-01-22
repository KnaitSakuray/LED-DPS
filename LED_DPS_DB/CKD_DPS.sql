CREATE TABLE [dbo].[CKD_DPS]
(
    [CKD_PK] VARCHAR(20) NOT NULL, 
    [modelo_id_fk] INT NOT NULL, 
    [status_op] VARCHAR(50) NOT NULL, 
    [data] DATE NOT NULL, 
    [date_hora] DATETIME NOT NULL, 
    [qtd] INT NOT NULL, 
    [descricao] VARCHAR(50) NOT NULL, 
    [filial] INT NOT NULL, 
    CONSTRAINT [PK_CKD_DPS] PRIMARY KEY ([CKD_PK]), 
    CONSTRAINT [FK_CKD_DPS_ToMODELO] FOREIGN KEY ([modelo_id_fk]) REFERENCES MODELO_DPS([Id_modelo_PK])
)

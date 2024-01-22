CREATE TABLE [dbo].[Modelo_DPS]
(
	[Id_modelo_PK] INT NOT NULL IDENTITY , 
    [modelo] VARCHAR(50) NOT NULL, 
    [descricao] VARCHAR(50) NOT NULL, 
    [qtd_caixa] INT NOT NULL, 
    CONSTRAINT [PK_Modelo_DPS] PRIMARY KEY ([Id_modelo_PK])
)

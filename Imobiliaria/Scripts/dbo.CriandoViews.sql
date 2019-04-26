-- Criar view de resultado de solicitações (tela de index)
CREATE VIEW [dbo].[ViewSolicitacao] AS 

SELECT
	[S].[Id],
	[S].[DataSolicitacao],
	[S].[DataVistoria],
	[S].[IdSolicitador],
	[S].[IdVistoriador],
	[S].[Status],
	[E].[Rua],
	[E].[Cep],
	[E].[Bairro],
	[E].[Cidade],
	[E].[Numero],
	(SELECT TOP 1 [C].[Nome] FROM [Cliente] [C] WITH(NOLOCK) WHERE [C].[Id] = [I].[IdCliente]) AS [NomeProprietario],
	(SELECT TOP 1 [U].[UserName] FROM [AspNetUsers] [U] WITH(NOLOCK) WHERE [U].[Id] = [S].[IdVistoriador]) AS [NomeVistoriador]
FROM [Solicitacao] [S]
LEFT JOIN [Imovel] [I] ON [I].[Id] = [S].[IdImovel]
LEFT JOIN [Endereco] [E] ON  [E].[Id] = [I].[Id]
GO
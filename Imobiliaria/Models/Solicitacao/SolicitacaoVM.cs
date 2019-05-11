using Imobiliaria.Helpers;
using System;

namespace Imobiliaria.Models.Solicitacao
{
    public class SolicitacaoVM
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public string IdVistoriador { get; set; }
        public string IdSolicitador { get; set; }
        public byte Status { get; set; }
        public int IdImovel { get; set; }

        // METODO DE TESTE
        public void SimularCriacaoDeSolicitacao(string idVistoriador, string idSolicitador)
        {
            DataSolicitacao = new DateTime(2019, 05, 01);
            DataVistoria = DateTime.UtcNow.AddDays(1).Date;
            IdVistoriador = idVistoriador;
            IdSolicitador = idSolicitador;
            Status = Constants.StatusSolicitacao.Aguardando;
            IdImovel = 2; // No banco imovel do cliente 1
        }
    }
}

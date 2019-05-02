using Imobiliaria.Models.Solicitacao;
using System;

namespace Imobiliaria.Models
{
    public class LogSolicitacaoVM
    {
        public int Id { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public int IdVistoriador { get; set; }
        public int IdSolicitador { get; set; }
        public string Descricao { get; set; }

        public SolicitacaoVM Solicitacao { get; set; }
    }
}

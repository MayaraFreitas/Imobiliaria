using System;

namespace Imobiliaria.Service.VOs
{
    public class LogSolicitacaoVO
    {
        public int Id { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public int IdVistoriador { get; set; }
        public int IdSolicitador { get; set; }
        public string Descricao { get; set; }

        public SolicitacaoVO Solicitacao { get; set; }
    }
}

using System;

namespace Imobiliaria.Service.VOs
{
    public class SolicitacaoVO
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public int IdVistoriador { get; set; }
        public int IdSolicitador { get; set; }
    }
}

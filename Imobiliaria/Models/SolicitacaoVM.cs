using System;

namespace Imobiliaria.Models
{
    public class SolicitacaoVM
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public int IdVistoriados { get; set; }
        public int IdSolicitador { get; set; }
    }
}

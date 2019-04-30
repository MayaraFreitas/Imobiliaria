using System;

namespace Imobiliaria.Models.Solicitacao
{
    public class SolicitacaoVM
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public string IdVistoriados { get; set; }
        public string IdSolicitador { get; set; }
        public byte Status { get; set; }
        public int IdImovel { get; set; }
    }
}

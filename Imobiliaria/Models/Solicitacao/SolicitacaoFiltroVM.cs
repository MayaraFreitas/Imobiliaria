using System;

namespace Imobiliaria.Models.Solicitacao
{
    public class SolicitacaoFiltroVM
    {
        public string NomeVistoriador { get; set; }
        public string NomeProprietario { get; set; }
        public int? Codigo { get; set; }
        public byte? Status { get; set; }
        public DateTime? DataSolicitacao { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public string EnderecoRua { get; set; }
        public string IdSolicitador { get; set; }
    }
}

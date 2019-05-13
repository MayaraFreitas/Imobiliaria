using System;

namespace Imobiliaria.Service.VOs
{
    public class SolicitacaoFiltroVO
    {
        public string NomeVistoriador { get; set; }
        public string NomeProprietario { get; set; }
        public int? Codigo { get; set; }
        public byte? Status { get; set; }
        public DateTime? DataSolicitacao { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public string EnderecoRua { get; set; }
        public string IdUsuario { get; set; }
        public byte TipoUsuario { get; set; }

        public string Validar()
        {

            return null;
        }
    }
}

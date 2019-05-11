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
        public string IdUsuario { get; set; }
        public byte TipoUsuario { get; set; }

        public void FiltroPadrao(string idUsuario, byte tipoUsuario)
        {
            NomeVistoriador = null;
            NomeProprietario = null;
            Codigo = null;
            Status = null;
            DataSolicitacao = null;
            DataAgendamento = null;
            EnderecoRua = null;
            IdUsuario = idUsuario;
            TipoUsuario = tipoUsuario;
        }
    }
}

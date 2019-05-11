using System.Collections.Generic;

namespace Imobiliaria.Models.Solicitacao
{
    public class SolicitacaoIndexVM
    {
        public SolicitacaoFiltroVM Filtro { get; set; }
        public IEnumerable<ViewSolicitacaoVM> LstViewSolicitacaoVM { get; set; }

        public byte TipoUsuario { get; set; }
    }
}

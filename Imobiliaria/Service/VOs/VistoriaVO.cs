using System;
using System.Collections.Generic;

namespace Imobiliaria.Service.VOs
{
    public class VistoriaVO
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataFim { get; set; }

        public SolicitacaoVO Solicitacao { get; set; }
        public List<ComodoVO> LstComodo { get; set; }
        public List<MedicaoVO> LstMedicao { get; set; }
    }
}

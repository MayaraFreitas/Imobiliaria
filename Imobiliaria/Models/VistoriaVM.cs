using System;
using System.Collections.Generic;

namespace Imobiliaria.Models
{
    public class VistoriaVM
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataFim { get; set; }

        public SolicitacaoVM Solicitacao { get; set; }
        public List<ComodoVM> LstComodo { get; set; }
        public List<MedicaoVM> LstMedicao { get; set; }
    }
}

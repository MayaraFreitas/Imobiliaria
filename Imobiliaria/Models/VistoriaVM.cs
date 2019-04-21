using System;

namespace Imobiliaria.Models
{
    public class VistoriaVM
    {
        public int pkVistoria { get; set; }
        public DateTime dataInicio { get; set; }
        public bool ativo { get; set; }
        public DateTime dataFim { get; set; }
    }
}

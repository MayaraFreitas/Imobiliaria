using System;

namespace Imobiliaria.Models
{
    public class MedicaoVM
    {
        public int pkMedicao { get; set; }
        public String agua { get; set; }
        public String energia { get; set; }
        public String extintor { get; set; }
        public String gas { get; set; }
        public bool ativo { get; set; }
    }
}

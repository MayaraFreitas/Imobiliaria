using System;

namespace Imobiliaria.Service.VOs
{
    public class MedicaoVO
    {
        public int pkMedicao { get; set; }
        public String agua { get; set; }
        public String energia { get; set; }
        public String extintor { get; set; }
        public String gas { get; set; }
        public bool ativo { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}

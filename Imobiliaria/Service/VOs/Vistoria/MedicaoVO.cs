using System;

namespace Imobiliaria.Service.VOs.Vistoria
{
    public class MedicaoVO
    {
        public int Id { get; set; }
        public string Agua { get; set; }
        public string Energia { get; set; }
        public string Extintor { get; set; }
        public string Gas { get; set; }
        public bool Ativo { get; set; }

        public VistoriaVO Vistoria { get; set; }

        public string Validar()
        {
            return null;
        }
    }
}

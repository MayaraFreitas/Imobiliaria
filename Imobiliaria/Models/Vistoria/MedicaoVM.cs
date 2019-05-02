using System;

namespace Imobiliaria.Models.Vistoria
{
    public class MedicaoVM
    {
        public int Id { get; set; }
        public string Agua { get; set; }
        public string Energia { get; set; }
        public string Extintor { get; set; }
        public string Gas { get; set; }
        public bool Ativo { get; set; }

        public VistoriaVM Vistoria { get; set; }
    }
}

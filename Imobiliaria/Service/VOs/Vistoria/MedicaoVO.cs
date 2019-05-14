using System;

namespace Imobiliaria.Service.VOs.Vistoria
{
    public class MedicaoVO
    {
        public int Id { get; set; }
        public string Agua { get; set; }
        public string Energia { get; set; }
        public byte Extintor { get; set; }
        public byte GasEncanado { get; set; }
        public bool Ativo { get; set; }
        public int IdVistoria { get; set; }
        public VistoriaVO Vistoria { get; set; }

        public string Validar()
        {
            return null;
        }
    }
}

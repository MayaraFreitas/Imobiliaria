using Imobiliaria.Helpers;
using Imobiliaria.Resources;
using System;

namespace Imobiliaria.Models.Vistoria
{
    public class MedicaoVM
    {
        public int Id { get; set; }
        public string Agua { get; set; }
        public string Energia { get; set; }
        public byte Extintor { get; set; }
        public byte GasEncanado { get; set; }
        public bool Ativo { get; set; }
        public int IdVistoria { get; set; }

        public VistoriaVM Vistoria { get; set; }

        public string StatusAgua
        {
            get
            {
                return string.IsNullOrEmpty(Agua) ? string.Format(Resource.Comum_Medicao_Indefinida, Resource.Comum_Agua) : Agua;
            }
        }
        public string StatusEnergia
        {
            get
            {
                return string.IsNullOrEmpty(Energia) ? string.Format(Resource.Comum_Medicao_Indefinida, Resource.Comum_Energia) : Energia;
            }
        }

        public string ExtintorStr
        {
            get
            {
                return Extintor == Constants.SimNao.Sim ? Resource.Commum_Sim : Resource.Commum_Nao;
            }
        }
        public string GasEncanadoStr
        {
            get
            {
                return GasEncanado == Constants.SimNao.Sim ? Resource.Commum_Sim : Resource.Commum_Nao;
            }
        }
    }
}

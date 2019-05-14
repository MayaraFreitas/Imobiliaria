using Imobiliaria.Helpers;
using System;
using System.Collections.Generic;

namespace Imobiliaria.Service.VOs.Vistoria
{
    public class VistoriaVO
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public byte Status { get; set; }
        public DateTime? DataFim { get; set; }

        //public SolicitacaoVO Solicitacao { get; set; }
        public ICollection<ComodoVO> LstComodo { get; set; }
        public MedicaoVO Medicao { get; set; }

        public string Validar()
        {
            return null;
        }

        public void IniciarVistoria()
        {
            DataInicio = DateTime.UtcNow;
            Status = Constants.StatusVistoria.EmVistoria;
            DataFim = null;
        }
    }
}

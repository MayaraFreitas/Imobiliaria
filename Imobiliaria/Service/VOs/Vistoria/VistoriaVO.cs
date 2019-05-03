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

        public SolicitacaoVO Solicitacao { get; set; }
        public List<ComodoVO> LstComodo { get; set; }
        public List<MedicaoVO> LstMedicao { get; set; }

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

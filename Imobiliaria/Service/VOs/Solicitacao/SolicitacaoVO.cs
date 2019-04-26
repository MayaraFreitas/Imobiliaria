using Imobiliaria.Helpers;
using Imobiliaria.Resources;
using System;

namespace Imobiliaria.Service.VOs
{
    public class SolicitacaoVO
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public string IdVistoriador { get; set; }
        public string IdSolicitador { get; set; }
        public byte Status { get; set; }

        public string Validar()
        {
            if (DataVistoria <= DateTime.UtcNow)
            {
                return string.Format(Resource.Comum_Erro_Data_MenorQueAtual, Resource.Vistoria_DataVistoria);
            }

            if (string.IsNullOrEmpty(IdVistoriador))
            {
                return Resource.Usuario_Erro_VistoriadorInvalido;
            }

            if (string.IsNullOrEmpty(IdSolicitador))
            {
                return Resource.Usuario_Erro_SolicitadorInvalido;
            }

            return null;
        }

        public void CriarSolicitacao()
        {
            Status = Constants.StatusSolicitacao.Aguardando;
            DataSolicitacao = DateTime.UtcNow;
        }
    }
}

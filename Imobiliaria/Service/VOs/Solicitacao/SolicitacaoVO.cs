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
        public bool Ativo { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}

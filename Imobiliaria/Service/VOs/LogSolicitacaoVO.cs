using System;

namespace Imobiliaria.Service.VOs
{
    public class LogSolicitacaoVO
    {
        public int pkLog { get; set; }
        public DateTime data { get; set; }
        public string vistoriador { get; set; }
        public String descricao { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}

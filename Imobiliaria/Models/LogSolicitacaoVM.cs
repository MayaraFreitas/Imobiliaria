using System;

namespace Imobiliaria.Models
{
    public class LogSolicitacaoVM
    {
        public int pkLog { get; set; }
        public DateTime data { get; set; }
        public string vistoriador { get; set; }
        public String descricao { get; set; }
    }
}

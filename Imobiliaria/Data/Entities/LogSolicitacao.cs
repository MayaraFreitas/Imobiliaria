using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Entities
{
    public class LogSolicitacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pkLog { get; set; }
        public DateTime data { get; set; }
        public string vistoriador { get; set; }
        public String descricao { get; set; }

        Solicitacao solicitaocao;

      
        public Solicitacao Solicitaocao { get => solicitaocao; set => solicitaocao = value; }
    }
}

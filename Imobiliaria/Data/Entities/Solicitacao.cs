using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Entities
{
    public class Solicitacao
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get;set; }
        public DateTime DataVistoria { get; set; }
        public int IdVistoriador { get; set; }
        public int IdSolicitador { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Entities
{
    [Table("ViewComodo")]
    public class ViewComodo
    {
        public int Id { get; set; }
        public int IdVistoria { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string CorTeto { get; set; }
        public string CorParede { get; set; }
        public int NumeroDeNotas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Entities
{
    public class LogSolicitacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public int IdVistoriador { get; set; }
        public int IdSolicitador { get; set; }
        public string Descricao { get; set; }

        public Solicitacao Solicitacao { get; set; }
    }
}

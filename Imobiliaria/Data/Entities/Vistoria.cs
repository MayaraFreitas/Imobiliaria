using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Vistoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public byte Status { get; set; }
        public DateTime? DataFim { get; set; }
        public int IdSolicitacao { get; set; }

        [ForeignKey("IdSolicitacao")]
        public Solicitacao Solicitacao { get; set; }
        public virtual ICollection<Comodo> LstComodo { get; set; }
        public Medicao Medicao { get; set; }
    }
}
   

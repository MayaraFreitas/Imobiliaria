using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Solicitacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataSolicitacao { get;set; }
        public DateTime DataVistoria { get; set; }
        public string IdVistoriador { get; set; }
        public string IdSolicitador { get; set; }
        public bool Ativo { get; set; }
    }
}

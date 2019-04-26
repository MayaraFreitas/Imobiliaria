using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    [Table("Solicitacao")]
    public class Solicitacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataSolicitacao { get;set; }
        public DateTime DataVistoria { get; set; }
        public string IdVistoriador { get; set; }
        public string IdSolicitador { get; set; }
        public byte Status { get; set; }
        public int IdImovel { get; set; }
        //User usuario;
        // List<User> usuarios = new List<User>();
        //public Vistoria Vistoria { get; set; }
        //public List<LogSolicitacao> LstLogSolicitacao { get; set; }
    }
}

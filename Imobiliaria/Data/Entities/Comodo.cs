
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Comodo
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public byte[] Imagem { get; set; }
        public byte CorTeto { get; set; }
        public byte CorParede { get; set; }
        public int IdVistoria { get; set; }

        [ForeignKey("IdVistoria")]
        public Vistoria Vistoria { get; set; }

        public virtual ICollection<Nota> LstNota { get; set; }
    }
}

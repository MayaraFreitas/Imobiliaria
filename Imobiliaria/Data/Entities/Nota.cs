using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Entities
{
    public class Nota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pkNota { get; set; }
        public String descricao { get; set; }
        public string imagem { get; set; }
        public String titulo { get; set; }

        Comodo comodo;

        public Nota()
        {
        }

        public int PkNota { get => pkNota; set => pkNota = value; }
    }
}

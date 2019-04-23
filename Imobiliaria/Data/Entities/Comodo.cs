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
        public string Imagem { get; set; }
        public string CorTeto { get; set; }
        public string CorParede { get; set; }

        public Vistoria Vistoria { get; set; }
        public List<Nota> LstNota { get; set; }
    }
}

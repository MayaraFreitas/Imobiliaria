using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Comodo
    {
        public int pkComodo { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public String imagem { get; set; }
        public String corTeto { get; set; }
        public String corParede { get; set; }

        Vistoria vistoria;
        List<Nota> nota = new List<Nota>();


        public Comodo()
        {
        }

      
    }
}

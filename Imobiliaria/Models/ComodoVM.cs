using System;

namespace Imobiliaria.Models
{
    public class ComodoVM
    {
        public int pkComodo { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public String imagem { get; set; }
        public String corTeto { get; set; }
        public String corParede { get; set; }
    }
}

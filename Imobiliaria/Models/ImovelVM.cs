using System;

namespace Imobiliaria.Models
{
    public class ImovelVM
    {
        public int pkImovel { get; set; }
        public int area { get; set; }
        public bool ativo { get; set; }
        public int idade { get; set; }
        public bool seguro { get; set; }
    }
}

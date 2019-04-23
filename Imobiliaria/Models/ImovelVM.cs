using System;

namespace Imobiliaria.Models
{
    public class ImovelVM
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public bool Ativo { get; set; }
        public int Idade { get; set; }
        public bool Seguro { get; set; }

        public ClienteVM Cliente { get; set; }
        public EnderecoVM Endereco { get; set; }
    }
}

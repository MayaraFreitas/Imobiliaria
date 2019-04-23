using System;

namespace Imobiliaria.Service.VOs
{
    public class ImovelVO
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public bool Ativo { get; set; }
        public int Idade { get; set; }
        public bool Seguro { get; set; }

        public ClienteVO Cliente { get; set; }
        public EnderecoVO Endereco { get; set; }
    }
}

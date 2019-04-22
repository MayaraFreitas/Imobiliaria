using System;

namespace Imobiliaria.Service.VOs
{
    public class EnderecoVO
    {
        public int pkEndereco { get; set; }
        public string rua { get; set; }
        public int cep { get; set; }
        public string bairro { get; set; }
        public bool ativo { get; set; }
        public string cidade { get; set; }
        public int numero { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}

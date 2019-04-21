using System;

namespace Imobiliaria.Service.VOs
{
    public class ComodoVO
    {
        public int pkComodo { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public String imagem { get; set; }
        public String corTeto { get; set; }
        public String corParede { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}

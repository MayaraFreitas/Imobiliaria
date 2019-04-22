using System;

namespace Imobiliaria.Service.VOs
{
    public class ImovelVO
    {
        public int pkImovel { get; set; }
        public int area { get; set; }
        public bool ativo { get; set; }
        public int idade { get; set; }
        public bool seguro { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}

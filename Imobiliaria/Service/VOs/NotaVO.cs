using System;

namespace Imobiliaria.Service.VOs
{
    public class NotaVO
    {
        public int pkNota { get; set; }
        public String descricao { get; set; }
        public string imagem { get; set; }
        public String titulo { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}

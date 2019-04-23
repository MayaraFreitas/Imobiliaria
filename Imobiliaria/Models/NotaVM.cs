using System;

namespace Imobiliaria.Models
{
    public class NotaVM
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public int IdComodo { get; set; }

        public ComodoVM Comodo { get; set; }
    }
}

using System;

namespace Imobiliaria.Service.VOs
{
    public class NotaVO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public int IdComodo { get; set; }

        public ComodoVO Comodo { get; set; }
    }
}

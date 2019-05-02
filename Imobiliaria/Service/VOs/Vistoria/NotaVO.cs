using System;

namespace Imobiliaria.Service.VOs.Vistoria
{
    public class NotaVO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public int IdComodo { get; set; }

        public ComodoVO Comodo { get; set; }

        public string Validar()
        {
            return null;
        }
    }
}

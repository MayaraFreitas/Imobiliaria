using System;
using System.Collections.Generic;

namespace Imobiliaria.Service.VOs.Vistoria
{
    public class ComodoVO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string CorTeto { get; set; }
        public string CorParede { get; set; }

        public VistoriaVO Vistoria { get; set; }
        public List<NotaVO> LstNota { get; set; }

        public string Validar()
        {
            return null;
        }
    }
}

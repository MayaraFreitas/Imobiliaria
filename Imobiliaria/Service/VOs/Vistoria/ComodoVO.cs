using System;
using System.Collections.Generic;

namespace Imobiliaria.Service.VOs.Vistoria
{
    public class ComodoVO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public byte[] Imagem { get; set; }
        public byte CorTeto { get; set; }
        public byte CorParede { get; set; }
        public int IdVistoria { get; set; }

        //public VistoriaVO Vistoria { get; set; }
        public ICollection<NotaVO> LstNota { get; set; }

        public string Validar()
        {
            return null;
        }
    }
}

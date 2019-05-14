using System.Collections.Generic;

namespace Imobiliaria.Models.Vistoria
{
    public class ComodoVM
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public byte[] Imagem { get; set; }
        public byte CorTeto { get; set; }
        public byte CorParede { get; set; }
        public int IdVistoria { get; set; }

        public VistoriaVM Vistoria { get; set; }
        public ICollection<NotaVM> LstNota { get; set; }
    }
}

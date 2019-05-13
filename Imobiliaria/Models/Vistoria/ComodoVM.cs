using System.Collections.Generic;

namespace Imobiliaria.Models.Vistoria
{
    public class ComodoVM
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string CorTeto { get; set; }
        public string CorParede { get; set; }

        public VistoriaVM Vistoria { get; set; }
        public List<NotaVM> LstNota { get; set; }
    }
}

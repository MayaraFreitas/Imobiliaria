namespace Imobiliaria.Models.Vistoria
{
    public class ViewComodoVM
    {
        public int Id { get; set; }
        public int IdVistoria { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string CorTeto { get; set; }
        public string CorParede { get; set; }
        public int NumeroDeNotas { get; set; }
    }
}

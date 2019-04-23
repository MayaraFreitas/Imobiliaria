namespace Imobiliaria.Models
{
    public class EnderecoVM
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public bool Ativo { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }

        public UserVM Usuario { get; set; }
        public ClienteVM Cliente { get; set; }
        public ImovelVM Imovel { get; set; }
        public EmpresaVM Empresa { get; set; }
    }
}

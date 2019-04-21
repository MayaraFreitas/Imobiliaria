using System;

namespace Imobiliaria.Models
{
    public class EmpresaVM
    {
        public int pkEmpresa { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public string nomeFantasia { get; set; }
        public String inscricaoEstadual { get; set; }
        public String inscricaoMunicipal { get; set; }
        public string email { get; set; }
        public string contato { get; set; }
        public String site { get; set; }
        public bool ativo { get; set; }
        public String telefone { get; set; }
        public String celular { get; set; }
        public Boolean whatsapp { get; set; }
    }
}

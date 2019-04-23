using System;
using System.Collections.Generic;

namespace Imobiliaria.Models
{
    public class EmpresaVM
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string Site { get; set; }
        public bool Ativo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Whatsapp { get; set; }

        public EnderecoVM Endereco { get; set; }
        public UserVM Usuario { get; set; }
        public List<ClienteVM> LstCliente { get; set; }
    }
}

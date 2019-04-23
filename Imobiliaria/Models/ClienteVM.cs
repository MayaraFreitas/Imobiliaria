using System;

namespace Imobiliaria.Models
{
    public class ClienteVM
    {
        public int CodigoCliente { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public bool Cargo { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        public string Email { get; set; }
        public bool Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Celular { get; set; }
        public bool Whatsapp { get; set; }
    }
}

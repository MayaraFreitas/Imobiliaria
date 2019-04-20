using System;

namespace ImobiCore.Data.Entities
{
    public class Cliente
    {
        int pkCliente;
        string nome;
        string documento;
        Boolean cargo;
        String telefone;
        bool ativo;
        string email;
        bool sexo;
        DateTime nascimento;
        String celular;
        Boolean whatsapp;

        Endereco endereco;
        List<Imovel> imovel = new List<Imovel>();

        //Construtor
        public Cliente()
        {
        }

        public int PkCliente { get => pkCliente; set => pkCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Documento { get => documento; set => documento = value; }
        public bool Cargo { get => cargo; set => cargo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Email { get => email; set => email = value; }
        public bool Sexo { get => sexo; set => sexo = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Celular { get => celular; set => celular = value; }
        public bool Whatsapp { get => whatsapp; set => whatsapp = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
    }
}

using System;

namespace ImobiCore.Data.Entities
{
    public class Empresa
    {
        int pkEmpresa;
        string razaoSocial;
        string cnpj;
        string nomeFantasia;
        String inscricaoEstadual;
        String inscricaoMunicipal;
        string email;
        string contato;
        String site;
        bool ativo;
        String telefone;
        String celular;
        Boolean whatsapp;

        Endereco endereco;
        User usuario;

        List<Cliente> cliente = new List<Cliente>();


        public Empresa()
        {
        }

        public int PkEmpresa { get => pkEmpresa; set => pkEmpresa = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public string InscricaoMunicipal { get => inscricaoMunicipal; set => inscricaoMunicipal = value; }
        public string Email { get => email; set => email = value; }
        public string Contato { get => contato; set => contato = value; }
        public string Site { get => site; set => site = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public bool Whatsapp { get => whatsapp; set => whatsapp = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
        public User Usuario { get => usuario; set => usuario = value; }
        public List<Cliente> Cliente { get => cliente; set => cliente = value; }
    }
}

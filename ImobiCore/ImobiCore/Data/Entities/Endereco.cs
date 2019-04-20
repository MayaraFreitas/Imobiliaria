using System;

namespace ImobiCore.Data.Entities
{
    public class Endereco
    {
        int pkEndereco;
        string rua;
        int cep;
        string bairro;
        bool ativo;
        string cidade;
        int numero;

        User usuario;
        Cliente cliente;
        Imovel imovel;
        Empresa empresa;

        public Endereco()
        {
        }

        public int PkEndereco { get => pkEndereco; set => pkEndereco = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Cep { get => cep; set => cep = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int Numero { get => numero; set => numero = value; }
        public User Usuario { get => usuario; set => usuario = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Imovel Imovel { get => imovel; set => imovel = value; }
        public Empresa Empresa { get => empresa; set => empresa = value; }
    }
}
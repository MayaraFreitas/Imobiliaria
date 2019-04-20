using System;

namespace ImobiCore.Data.Entities
{
    public class Imovel
    {
        int pkImovel;
        int area;
        bool ativo;
        int idade;
        bool seguro;

        Cliente cliente;
        Endereco endereco;

        public Imovel()
        {

        }

        public int PkImovel { get => pkImovel; set => pkImovel = value; }
        public int Area { get => area; set => area = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public int Idade { get => idade; set => idade = value; }
        public bool Seguro { get => seguro; set => seguro = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
    }
}

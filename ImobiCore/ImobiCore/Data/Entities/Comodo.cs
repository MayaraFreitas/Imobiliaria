using System;

namespace ImobiCore.Data.Entities
{
    public class Comodo
    {
        int pkComodo;
        bool ativo;
        string nome;
        String imagem;
        String corTeto;
        String corParede;

        Vistoria vistoria;
        List<Nota> nota = new List<Nota>();


        public Comodo()
        {
        }

        public int PkComodo { get => pkComodo; set => pkComodo = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public string CorTeto { get => corTeto; set => corTeto = value; }
        public string CorParede { get => corParede; set => corParede = value; }
        public List<Nota> Nota { get => nota; set => nota = value; }
        public Vistoria Vistoria { get => vistoria; set => vistoria = value; }
    }
}

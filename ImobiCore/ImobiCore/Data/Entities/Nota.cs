using System;

namespace ImobiCore.Data.Entities
{
    public class Nota
    {
        int pkNota;
        String descricao;
        string imagem;
        String titulo;

        Comodo comodo;

        public Nota()
        {
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public Comodo Comodo { get => comodo; set => comodo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int PkNota { get => pkNota; set => pkNota = value; }
    }
}

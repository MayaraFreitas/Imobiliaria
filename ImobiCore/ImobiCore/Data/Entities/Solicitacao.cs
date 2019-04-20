using System;

namespace ImobiCore.Data.Entities
{
    public class Solicitacao
    {
        int pkSolicitacao;
        DateTime dataSolicitacao;
        bool ativo;
        DateTime dataVistoria;

        User usuario;
        List<User> usuarios = new List<User>();
        Vistoria vistoria;
        List<Log> log = new List<Log>();


        public Solicitacao()
        {
        }

        public int PkSolicitacao { get => pkSolicitacao; set => pkSolicitacao = value; }
        public DateTime DataSolicitacao { get => dataSolicitacao; set => dataSolicitacao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public DateTime DataVistoria { get => dataVistoria; set => dataVistoria = value; }
        public User Usuario { get => usuario; set => usuario = value; }
        public List<User> Usuarios { get => usuarios; set => usuarios = value; }
        public Vistoria Vistoria { get => vistoria; set => vistoria = value; }
        public List<Log> Log { get => log; set => log = value; }
    }
}

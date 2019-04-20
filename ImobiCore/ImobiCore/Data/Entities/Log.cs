using System;

namespace ImobiCore.Data.Entities
{
    public class Log
    {
        int pkLog;
        DateTime data;
        string vistoriador;
        String descricao;

        Solicitacao solicitaocao;

        public Log()
        {
        }

        public int PkLog { get => pkLog; set => pkLog = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Vistoriador { get => vistoriador; set => vistoriador = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Solicitacao Solicitaocao { get => solicitaocao; set => solicitaocao = value; }
    }
}

using System;

namespace ImobiCore.Data.Entities
{
    public class Vistoria
    {
        int pkVistoria;
        DateTime dataInicio;
        bool ativo;
        DateTime dataFim;

        Solicitacao solicitacao;

        List<Comodo> comodo = new List<Comodo>();
        List<Medicao> medicao = new List<Medicao>();

        public Vistoria()
        {
        }

        public int PkVistoria { get => pkVistoria; set => pkVistoria = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public DateTime DataFim { get => dataFim; set => dataFim = value; }
        public Solicitacao Solicitacao { get => solicitacao; set => solicitacao = value; }
        public List<Comodo> Comodo { get => comodo; set => comodo = value; }
        public List<Medicao> Medicao { get => medicao; set => medicao = value; }
    }
}
   

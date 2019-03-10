using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobi.Models.ViewModels.Vistoria
{
    public class Vistoria
    {
        public Vistoria()
        {

        }

        public Vistoria(long id, string nome, DateTime dataVistoria, byte status, long idSolicitacao, string observacao, bool energia, bool agua, bool gas)
        {
            Id = id;
            Nome = nome;
            DataVistoria = dataVistoria;
            Status = status;
            IdSolicitacao = idSolicitacao;
            Observacao = observacao;
            Energia = energia;
            Agua = agua;
            Gas = gas;
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataVistoria { get; set; }
        public byte Status { get; set; }
        public long IdSolicitacao { get; set; }
        public string Observacao { get; set; }

        //Tags
        public bool Energia { get; set; }
        public bool Agua { get; set; }
        public bool Gas { get; set; }
    }
}

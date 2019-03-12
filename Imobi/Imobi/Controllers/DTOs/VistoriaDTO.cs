using System;

namespace Imobi.Controllers.DTOs
{
    public class VistoriaDTO
    {
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

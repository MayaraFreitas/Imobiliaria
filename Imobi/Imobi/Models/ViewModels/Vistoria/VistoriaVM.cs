using System;
using System.ComponentModel.DataAnnotations;

namespace Imobi.Models.ViewModels.Vistoria
{
    public class VistoriaVM
    {
        public VistoriaVM()
        {

        }
 
        public long Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataVistoria { get; set; }
        public byte Status { get; set; }
        public long IdSolicitacao { get; set; }
        public string Observacao { get; set; }

        //public Usuario usuario { get; set; }
        //public int UsuarioId { get; set; }

        //Tags
        public bool Energia { get; set; }
        public bool Agua { get; set; }
        public bool Gas { get; set; }
    }
}

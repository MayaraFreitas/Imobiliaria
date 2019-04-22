using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Vistoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pkVistoria { get; set; }
        public DateTime dataInicio { get; set; }
        public bool ativo { get; set; }
        public DateTime dataFim { get; set; }

        Solicitacao solicitacao;

        List<Comodo> comodo = new List<Comodo>();
        List<Medicao> medicao = new List<Medicao>();

        public Vistoria()
        {
        }

        public Solicitacao Solicitacao { get => solicitacao; set => solicitacao = value; }
        public List<Comodo> Comodo { get => comodo; set => comodo = value; }
        public List<Medicao> Medicao { get => medicao; set => medicao = value; }
    }
}
   

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Imovel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Area { get; set; }
        public bool Ativo { get; set; }
        public int Idade { get; set; }
        public bool Seguro { get; set; }

        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        //public int IdEndereco { get; set; }
        //public Endereco Endereco { get; set; }
    }
}

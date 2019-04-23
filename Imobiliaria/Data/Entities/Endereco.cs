using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public bool Ativo { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }

        public User Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public Imovel Imovel { get; set; }
        public Empresa Empresa { get; set; }
    }
}
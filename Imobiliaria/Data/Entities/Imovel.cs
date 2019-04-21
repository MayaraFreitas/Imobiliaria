using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Imovel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pkImovel { get; set; }
        public int area  { get; set; }
        public bool ativo  { get; set; }
        public int idade  { get; set; }
        public bool seguro  { get; set; }

        Cliente cliente;
        Endereco endereco;

        public Imovel()
        {

        }

    }
}

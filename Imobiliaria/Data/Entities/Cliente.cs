using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoCliente { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public bool Cargo { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        public string Email { get; set; }
        public bool Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Celular { get; set; }
        public bool Whatsapp { get; set; }

        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }
        public Endereco Endereco { get; set; }

       // public IEnumerable<Imovel> LstImovel { get; set; }
    }
}

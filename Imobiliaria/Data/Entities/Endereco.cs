using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pkEndereco { get; set; }
        public string rua { get; set; }
        public int cep { get; set; }
        public string bairro { get; set; }
        public bool ativo { get; set; }
        public string cidade { get; set; }
        public int numero { get; set; }

        User usuario;
        Cliente cliente;
        Imovel imovel;
        Empresa empresa;

        public Endereco()
        {
        }
    }
}
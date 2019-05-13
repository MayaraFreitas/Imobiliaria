using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string Site { get; set; }
        public bool Ativo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Whatsapp { get; set; }

        //[ForeignKey("Standard")]
        //public int IdEndereco { get; set; }
       // public Endereco Endereco { get; set; }

        public List<Cliente> LstCliente { get; set; }

    }
}

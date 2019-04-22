using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pkEmpresa { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public string nomeFantasia { get; set; }
        public String inscricaoEstadual { get; set; }
        public String inscricaoMunicipal { get; set; }
        public string email { get; set; }
        public string contato { get; set; }
        public String site { get; set; }
        public bool ativo { get; set; }
        public String telefone { get; set; }
        public String celular { get; set; }
        public Boolean whatsapp { get; set; }

        Endereco endereco;
        User usuario;

        List<Cliente> cliente = new List<Cliente>(); 


        public Empresa()
        {
        }

        public List<Cliente> Cliente { get => cliente; set => cliente = value; }

    }
}

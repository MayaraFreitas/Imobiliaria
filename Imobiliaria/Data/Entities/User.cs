using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pkUsuario { get; set; }
        public string nome { get; set; }
        public string documento { get; set; }
        public String cargo { get; set; }
        public String telefone { get; set; }
        public bool ativo { get; set; }
        public string email { get; set; }
        public bool sexo { get; set; }
        public DateTime nascimento { get; set; }
        public string senha { get; set; }
        public String celular { get; set; }
        public Boolean whatsapp { get; set; }

        Endereco endereco;

        List<Empresa> empresas = new List<Empresa>();
        List<Solicitacao> solitacoes = new List<Solicitacao>();


    }
}

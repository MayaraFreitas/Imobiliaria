using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobi.Repository.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public decimal CNPJ { get; set; }  
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Whats { get; set; }
        public string Email { get; set; }
    }
}

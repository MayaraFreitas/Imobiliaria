using Imobi.Domain.Interfaces.Arguments;
using Imobi.Domain.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobi.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
        
    }
}

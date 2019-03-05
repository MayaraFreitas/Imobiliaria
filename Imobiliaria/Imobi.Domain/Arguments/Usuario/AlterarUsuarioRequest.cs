using System;

namespace Imobi.Domain.Arguments.Usuario
{
    public class AlterarUsuarioRequest
    {
        public Guid Id { get; set; }
        public string Email { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
    }
}

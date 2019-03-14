using System;
using Imobi.Domain.Entities;
using Imobi.Domain.VOs;

namespace Imobi.Domain.Arguments.Usuario
{
    public class AutenticarUsuarioResponse
    {
        public string PrimeiroNome { get; set; }
        public string Email { get; set; }
        public byte Status { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entities.Usuario entidade)
        {
            return new AutenticarUsuarioResponse()
            {
                Email = entidade.Email.Endereco,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                Status = entidade.Status
            };
        }
    }
}

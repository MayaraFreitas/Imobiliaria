using Imobi.Domain.Entities;
using Imobi.Domain.VOs;
using System;

namespace Imobi.Domain.Arguments.Usuario
{
    public class UsuarioReponse
    {
        public Guid Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
        public string Email { get; private set; }
        public byte Status { get; private set; }

        public static explicit operator UsuarioReponse(Entities.Usuario entidade)
        {
            return new UsuarioReponse()
            {
                Email = entidade.Email.Endereco,
                NomeCompleto = entidade.Nome.ToString(),
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                SobreNome = entidade.Nome.SobreNome,
                Id = entidade.Id,
                Status = entidade.Status
            };
        }
    }
}

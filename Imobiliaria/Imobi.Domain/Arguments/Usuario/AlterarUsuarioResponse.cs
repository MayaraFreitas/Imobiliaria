using System;
using Imobi.Domain.Entities;
using Imobi.Domain.Resources;

namespace Imobi.Domain.Arguments.Usuario
{
    public class AlterarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string Email { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
        public string Menssagem { get; private set; }

        public static explicit operator AlterarUsuarioResponse(Entities.Usuario entidade)
        {
            return new AlterarUsuarioResponse()
            {
                Email = entidade.Email.Endereco,
                Id = entidade.Id,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                SobreNome = entidade.Nome.SobreNome,
                Menssagem = Message.Generico_Operacao_Realizada_Com_Sucesso
            };
        }
    }
}

using Imobi.Domain.Interfaces.Arguments;
using System;

namespace Imobi.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarUsuarioResponse(Entities.Usuario entidade)
        {
            return new AdicionarUsuarioResponse()
            {
                Id = entidade.Id,
                Message = Resources.Message.Generico_Operacao_Realizada_Com_Sucesso
            };
        }
    }
}

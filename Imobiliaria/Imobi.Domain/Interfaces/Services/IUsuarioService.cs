using Imobi.Domain.Arguments.Usuario;
using Imobi.Domain.Interfaces.Services.Base;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace Imobi.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase
    {
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);
        AlterarUsuarioResponse AlterarUsuario(AlterarUsuarioRequest request);
        IEnumerable<UsuarioReponse> ListarUsuario();
    }
}

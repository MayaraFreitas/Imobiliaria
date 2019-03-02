using Imobi.Domain.Arguments.Usuario;
using System.Collections.Generic;

namespace Imobi.Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
        AdicionarUsuarioResponse AdicionarUsuario(AdicionandoUsuarioRequest request);
        AlterarUsuarioResponse AlterarUsuario(AlterarUsuarioRequest request);
        IEnumerable<UsuarioReponse> ListarUsuario();
    }
}

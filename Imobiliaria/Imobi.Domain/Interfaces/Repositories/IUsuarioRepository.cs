using Imobi.Domain.Entities;
using System.Collections.Generic;

namespace Imobi.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario AutenticarUsuario(string email, string senha);
        Usuario AdicionarUsuario(Usuario usuario);
        IEnumerable<Usuario> ListarUsuario();
    }
}

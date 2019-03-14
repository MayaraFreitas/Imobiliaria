using System;
using System.Collections.Generic;
using System.Linq;
using Imobi.Domain.Entities;
using Imobi.Domain.Interfaces.Repositories;

namespace Imobi.Infra.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        // Propriedades
        protected readonly ImobiContext _context;

        #region Construtor
        public UsuarioRepository(ImobiContext context)
        {
            _context = context;
        }
        #endregion

        #region Metodos

        public Usuario AdicionarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return usuario;
        }

        public void AlterarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario AutenticarUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ListarUsuario()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario ObterUsuarioPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

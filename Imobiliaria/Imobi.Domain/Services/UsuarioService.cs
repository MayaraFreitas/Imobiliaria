using Imobi.Domain.Arguments.Usuario;
using Imobi.Domain.Entities;
using Imobi.Domain.Interfaces.Repositories;
using Imobi.Domain.Interfaces.Services;
using Imobi.Domain.VOs;
using prmToolkit.NotificationPattern;
using System;
using Imobi.Domain.Resources;
using prmToolkit.NotificationPattern.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Imobi.Domain.Services
{
    public class UsuarioService : Notifiable, IUsuarioService
    {
        #region Propriedades

        private readonly IUsuarioRepository _usuarioRepo;

        #endregion

        #region Construtor

        public UsuarioService(IUsuarioRepository usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        #endregion

        #region Metodos

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionandoUsuarioRequest request)
        {
            // Instanciar classes para validar
            Nome nome = new Nome(request.Nome.PrimeiroNome, request.Nome.SobreNome);
            Email email = new Email(request.Email.Endereco);
  
            Usuario usuario = new Usuario(nome, email, request.Senha);
            if (this.IsInvalid())
            {
                return null;
            }

            // Inserir novo usuario
            usuario = _usuarioRepo.AdicionarUsuario(usuario);

            return (AdicionarUsuarioResponse)usuario;
        }

        public AlterarUsuarioResponse AlterarUsuario(AlterarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarUsuarioRequest", Message.Generico_Obrigatorio_0X.ToFormat("AutenticarUsuarioRequest"));
            }

            // Ao instanciar, através do construtor ocorre a validação
            Email email = new Email(request.Email);            
            Usuario usuario = new Usuario(email, request.Senha);

            // Verificar se existe notificação de erro
            AddNotifications(usuario, email);
            if (usuario.IsInvalid())
            {
                return null;
            }

           // Autenticar
            usuario = _usuarioRepo.AutenticarUsuario(usuario.Email.Endereco, usuario.Senha);

            return (AutenticarUsuarioResponse)usuario;
        }

        public IEnumerable<UsuarioReponse> ListarUsuario()
        {
            return _usuarioRepo.ListarUsuario().ToList().Select(usuario => (UsuarioReponse)usuario).ToList();
        }

        #endregion
    }
}

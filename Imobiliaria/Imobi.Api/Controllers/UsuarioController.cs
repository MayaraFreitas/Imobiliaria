using Imobi.Api.Controllers.Base;
using Imobi.Domain.Arguments.Usuario;
using Imobi.Domain.Interfaces.Services;
using Imobi.Infra.Transaction;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Imobi.Api.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUnitOfWork unitOfWork, IUsuarioService usuarioService) : base(unitOfWork)
        {
            _usuarioService = usuarioService;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarUsuarioRequest request)
        {
            try
            {
                var response = _usuarioService.AdicionarUsuario(request);
                return await ResponseAsync(response, _usuarioService);
            }
            catch (Exception e)
            {
                return await ResponseExceptionAsync(e);
            }
        }
    }
}
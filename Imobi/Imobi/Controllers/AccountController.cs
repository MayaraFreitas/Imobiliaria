using AutoMapper;
using Imobi.Models.ViewModels.Usuario;
using Imobi.Services;
using Imobi.Services.VOs.Account;
using Imobi.Services.VOs.Usuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imobi.Controllers
{
    public class AccountController : Controller
    {
        
        #region Propriedades

        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        #endregion

        #region Controller

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        #endregion

        //[Authorize]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(ViewUserLoginVM view)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }

            ViewUserLoginVO viewDTO = _mapper.Map<ViewUserLoginVO>(view);
            if (!_accountService.Login(viewDTO))
            {
                return View();
            }

            HttpContext.Session.SetString("NameKey","Microsoft");
            ViewData["Name"] = HttpContext.Session.GetString("NameKey");
            return RedirectToAction("Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserVM view)
        {
            // Simular criacao
            UserVO user = new UserVO()
            {
                Nome = "Mayara",
                Cargo = 1,
                Senha = "1234567",
                Documento = "",
                CodigoEmpresa = 1,
                Telefone = "19 9 3393232",
                Celular = "19 9 99932323",
                Whats = true,
                Email = "mayara@email.com"
            };

            string result = _accountService.CreateAccount(user);

            return RedirectToAction("Login");
        }

        [Authorize]
        public IActionResult Home()
        {
            ViewData["DataTeste"] = HttpContext.Session.GetString("NameKey");
            return View();
        }
    }
}
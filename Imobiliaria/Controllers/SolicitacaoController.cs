using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Imobiliaria.Models;
using Imobiliaria.Service;
using Imobiliaria.Service.VOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Imobiliaria.Controllers
{
    public class SolicitacaoController : Controller
    {
        #region Injeção
        private readonly IVistoriaService _vistoriaService;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;

        public SolicitacaoController(IVistoriaService vistoriaService, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _vistoriaService = vistoriaService;
            _mapper = mapper;
            _userManager = userManager;
        }

        #endregion

        public IActionResult Index()
        {
           // var user = _userManager.GetUserAsync(HttpContext.User);
            var lst = _vistoriaService.FindAll();
            return View();
        }

        [HttpPost]
        public IActionResult Index(SolicitacaoVM solicitacao)
        {
            testeInserirSolicitação();//Metodo para testar inserção de solicitação sem o front
            return View();
        }


        private string testeInserirSolicitação()
        {
            //var user = _userManager.GetUserAsync(HttpContext.User);
            //var test = _userManager.GetUserId(HttpContext.User);
            SolicitacaoVO solicitacao = new SolicitacaoVO()
            {
                DataSolicitacao = new DateTime(2019,04,19),
                DataVistoria = new DateTime(2019, 05, 10),
                IdSolicitador = _userManager.GetUserId(HttpContext.User),
                IdVistoriador = _userManager.GetUserId(HttpContext.User)
            };

            _vistoriaService.InserirSolicitacao(solicitacao);

            return null;
        }
    }
}
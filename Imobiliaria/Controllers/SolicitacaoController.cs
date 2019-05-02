using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Imobiliaria.Helpers;
using Imobiliaria.Models;
using Imobiliaria.Models.Solicitacao;
using Imobiliaria.Service;
using Imobiliaria.Service.VOs;
using Imobiliaria.Service.VOs.Solicitacao;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

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
            SolicitacaoFiltroVO filtroVO = new SolicitacaoFiltroVO() { IdSolicitador = _userManager.GetUserId(HttpContext.User)};
            var lst = _vistoriaService.BuscarViewSolicitacao(filtroVO);
            return View();
        }

        [HttpPost]
        public IActionResult Index(SolicitacaoIndexVM model)
        {
            testeInserirSolicitação();//Metodo para testar inserção de solicitação sem o front

            // Setando usuario logado provisoriamente, enquanto nao vem da tela :)
            model.Filtro.IdSolicitador = _userManager.GetUserId(HttpContext.User);

            // Convertendo filtro para VO antes de ir para a camada de negócio
            SolicitacaoFiltroVO filtroVO = _mapper.Map<SolicitacaoFiltroVO>(model.Filtro);

            // Buscando Solicitacoes
            IEnumerable<ViewSolicitacaoVO> lstViewSolicitacaoVO = _vistoriaService.BuscarViewSolicitacao(filtroVO);

            // Convertendo resultado para VM e adicionando no model
            model.LstViewSolicitacaoVM = _mapper.Map<IEnumerable<ViewSolicitacaoVM>>(lstViewSolicitacaoVO);

            // Retornar 
            return View(model);
        }

        public IActionResult Criar()
        {
            // Buscar dados necessários para criar, por exemplo: Lista de Vistoriadores, imoveis... 
            // Ou buscar por Ajax e depois de preencher a data, assim pode buscar por vistoriadores disponiveis 
            return View();
        }

        [HttpPost]
        public IActionResult Criar(SolicitacaoVM solicitacao)
        {
            // Mapear VM para VO
            SolicitacaoVO solicitacaoVO = _mapper.Map<SolicitacaoVO>(solicitacao);

            // Criar solicitacao
            _vistoriaService.InserirSolicitacao(solicitacaoVO);

            // Verificar se houve erro, se sim apresentar erro na tela

            // Retornar para a view de index (procurar comando para redirecionar)
            return View();
        }

        public IActionResult SolicitacaoPDF()
        {
            SolicitacaoVO solicitacaoVO = _vistoriaService.ExportarPDF(2);

            SolicitacaoVM solicitacao = _mapper.Map<SolicitacaoVM>(solicitacaoVO);

            var pdf = new ViewAsPdf(solicitacao)
            {
                PageMargins = { Left = 20, Bottom = 20, Right = 20, Top = 20 },
                CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 12",
                PageSize = Rotativa.AspNetCore.Options.Size.A4
            };
            return pdf;
        }


        #region Metodos de simulação
        private string testeInserirSolicitação()
        {
            //var user = _userManager.GetUserAsync(HttpContext.User);
            //var test = _userManager.GetUserId(HttpContext.User);
            SolicitacaoVO solicitacao = new SolicitacaoVO()
            {
                DataSolicitacao = new DateTime(2019, 04, 19),
                DataVistoria = new DateTime(2019, 05, 10),
                IdSolicitador = _userManager.GetUserId(HttpContext.User),
                IdVistoriador = _userManager.GetUserId(HttpContext.User),
                Status = Constants.StatusAtivo.Ativo,
                IdImovel = 1
            };

            _vistoriaService.InserirSolicitacao(solicitacao);

            return null;
        }
        #endregion
    }
}
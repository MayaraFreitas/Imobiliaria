using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Imobiliaria.Helpers;
using Imobiliaria.Models;
using Imobiliaria.Models.Solicitacao;
using Imobiliaria.Models.Vistoria;
using Imobiliaria.Service;
using Imobiliaria.Service.VOs;
using Imobiliaria.Service.VOs.Solicitacao;
using Imobiliaria.Service.VOs.Vistoria;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace Imobiliaria.Controllers
{
    public class SolicitacaoController : Controller
    {
        #region Injeção
        private readonly IVistoriaService _vistoriaService;
        private readonly IGenericoService _genericoService;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private byte tipoDeUsuario;

        public SolicitacaoController(IVistoriaService vistoriaService, IGenericoService genericoService, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _vistoriaService = vistoriaService;
            _mapper = mapper;
            _userManager = userManager;
            _genericoService = genericoService;
        }

        #endregion

        public IActionResult Index()
        {
            // Instanciando view
            SolicitacaoIndexVM model = new SolicitacaoIndexVM();

            // buscando tipo de usuario logado. Busca temporária enquanto não é feito da forma correta!!!!!
            model.TipoUsuario = _genericoService.BuscarTipoUsuario(_userManager.GetUserId(HttpContext.User));

            // Setando filtro padrão com o usuário logado - TESTE
            SolicitacaoFiltroVM filtro = new SolicitacaoFiltroVM();
            filtro.FiltroPadrao(_userManager.GetUserId(HttpContext.User), model.TipoUsuario);

            // Buscando Solicitacoes
            IEnumerable<ViewSolicitacaoVO> lstViewSolicitacaoVO = _vistoriaService.BuscarViewSolicitacao(_mapper.Map<SolicitacaoFiltroVO>(filtro));

            // Adicionando filtro no objeto
            model.Filtro = filtro;

            // Convertendo resultado para VM e adicionando no model
            model.LstViewSolicitacaoVM = _mapper.Map<IEnumerable<ViewSolicitacaoVM>>(lstViewSolicitacaoVO);

            // Retornar 
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(SolicitacaoIndexVM model)
        {
            // Setando usuario logado provisoriamente, enquanto nao vem da tela :)
            model.Filtro.IdUsuario = _userManager.GetUserId(HttpContext.User);

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
            // TRECHO APENAS PARA TESTE ENQUANTO NAO TEM TELA
            solicitacao.SimularCriacaoDeSolicitacao(_userManager.GetUserId(HttpContext.User), _userManager.GetUserId(HttpContext.User));

            // Mapear VM para VO
            SolicitacaoVO solicitacaoVO = _mapper.Map<SolicitacaoVO>(solicitacao);

            // Criar solicitacao
            string result = _vistoriaService.InserirSolicitacao(solicitacaoVO);

            // Verificar se houve erro, se sim apresentar erro na tela
            if (!string.IsNullOrEmpty(result))
            {
                // MOSTRAR MENSAGEM DE ERRO

                //serializar informacao para enviar

                // retornar para a mesma tela
                return View();
            }

            // Retornar para a view de index (procurar comando para redirecionar)
            return RedirectToAction("Index");
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
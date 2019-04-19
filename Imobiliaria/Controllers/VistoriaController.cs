using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Imobiliaria.Models;
using Imobiliaria.Service;
using Imobiliaria.Service.VOs;
using Microsoft.AspNetCore.Mvc;

namespace Imobiliaria.Controllers
{
    public class VistoriaController : Controller
    {
        #region Injeção
        private readonly IVistoriaService _vistoriaService;
        private readonly IMapper _mapper;

        public VistoriaController(IVistoriaService vistoriaService, IMapper mapper)
        {
            _vistoriaService = vistoriaService;
            _mapper = mapper;
        }

        #endregion

        public IActionResult Index()
        {
            IList<SolicitacaoVO> lstSolicitacaoVO =  _vistoriaService.FindAll();
            IList<SolicitacaoVM> lstSolicitacaoVM = _mapper.Map<IList<SolicitacaoVM>>(lstSolicitacaoVO);
            return View();
        }

        [HttpPost]
        public IActionResult Index(string teste)
        {
            return View();
        }
    }
}
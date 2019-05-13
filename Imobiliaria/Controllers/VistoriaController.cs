using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Imobiliaria.Models;
using Imobiliaria.Models.Solicitacao;
using Imobiliaria.Service;
using Imobiliaria.Service.VOs;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

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

        public IActionResult SolicitacaoPDF()
        {
           VistoriaVO vistoriaVO = _vistoriaService.ExportarPDF(2); //Arrumar o objeto

            VistoriaVM vistoria = _mapper.Map<VistoriaVM>(vistoriaVO);

            var pdf = new ViewAsPdf(vistoria)
            {
                PageMargins = { Left = 20, Bottom = 20, Right = 20, Top = 20 },
                CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 12",
                PageSize = Rotativa.AspNetCore.Options.Size.A4
            };
            return pdf;
        }
        [HttpPost]
        public IActionResult Index(string teste)
        {
            return View();
        }
    }
}
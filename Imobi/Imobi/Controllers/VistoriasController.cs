using AutoMapper;
using Imobi.Controllers.DTOs;
using Imobi.Models.ViewModels.Vistoria;
using Imobi.Services.ServiceInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Imobi.Controllers
{
    public class VistoriasController : Controller
    {
        //Declarando dependencia para VistoriaService
        private readonly IVistoriaService _vistoriaService;
        private readonly IMapper _mapper;

        public VistoriasController(IVistoriaService vistoriaService, IMapper mapper)
        {
            _vistoriaService = vistoriaService;
            _mapper = mapper;
        }

        // Get
        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<VistoriaDTO> lstVistoriaDTO = _vistoriaService.FindAll();
            IEnumerable<VistoriaVM> list = _mapper.Map<IEnumerable<VistoriaVM>>(lstVistoriaDTO);
            return View(list);
        }

        #region Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VistoriaVM vistoria)
        {
            _vistoriaService.InserirVistoria(_mapper.Map<VistoriaDTO>(vistoria));

            return RedirectToAction(nameof(Index));
        }

        #endregion
    }
}
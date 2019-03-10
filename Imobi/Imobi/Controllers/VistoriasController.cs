using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imobi.Models.ViewModels.Vistoria;
using Imobi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Imobi.Controllers
{
    public class VistoriasController : Controller
    {
        //Declarando dependencia para VistoriaService
        private readonly VistoriaService _vistoriasService;

        public VistoriasController(VistoriaService vistoriasService)
        {
            _vistoriasService = vistoriasService;
        }

        // Get
        public IActionResult Index()
        {
            var list = _vistoriasService.FindAll();
            return View(list);
        }

        #region Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vistoria vistoria)
        {
            _vistoriasService.InserirVistoria(vistoria);

            return RedirectToAction(nameof(Index));
        }

        #endregion
    }
}
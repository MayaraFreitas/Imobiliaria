using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult Index()
        {
            var list = _vistoriasService.FindAll();
            return View(list);
        }
    }
}
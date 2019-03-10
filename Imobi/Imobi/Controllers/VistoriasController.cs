using Imobi.Models.ViewModels.Vistoria;
using Imobi.Services.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace Imobi.Controllers
{
    public class VistoriasController : Controller
    {
        //Declarando dependencia para VistoriaService
        private readonly IVistoriaService _vistoriaService;

        public VistoriasController(IVistoriaService vistoriaService)
        {
            _vistoriaService = vistoriaService;
        }

        // Get
        public IActionResult Index()
        {
            var list = _vistoriaService.FindAll();
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
            _vistoriaService.InserirVistoria(vistoria);

            return RedirectToAction(nameof(Index));
        }

        #endregion
    }
}
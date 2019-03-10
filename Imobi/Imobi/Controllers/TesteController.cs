using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Imobi.Models;
using Imobi.Models.ViewModels;

namespace Imobi.Controllers
{
    public class TesteController : Controller
    {
        private readonly ImobiContext _context;

        public TesteController(ImobiContext context)
        {
            _context = context;
        }

        // GET: Vistorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teste.ToListAsync());
        }

        // GET: Vistorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vistoria = await _context.Teste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vistoria == null)
            {
                return NotFound();
            }

            return View(vistoria);
        }

        // GET: Vistorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vistorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VistoriaDescricao")] Teste vistoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vistoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vistoria);
        }

        // GET: Vistorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vistoria = await _context.Teste.FindAsync(id);
            if (vistoria == null)
            {
                return NotFound();
            }
            return View(vistoria);
        }

        // POST: Vistorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VistoriaDescricao")] Teste vistoria)
        {
            if (id != vistoria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vistoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VistoriaExists(vistoria.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vistoria);
        }

        // GET: Vistorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vistoria = await _context.Teste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vistoria == null)
            {
                return NotFound();
            }

            return View(vistoria);
        }

        // POST: Vistorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vistoria = await _context.Teste.FindAsync(id);
            _context.Teste.Remove(vistoria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VistoriaExists(int id)
        {
            return _context.Teste.Any(e => e.Id == id);
        }
    }
}

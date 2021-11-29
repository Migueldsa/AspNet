using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using miguel.Models;
using miguel.Models.Dominio;

namespace miguel.Controllers
{
    public class OrdemController : Controller
    {
        private readonly Contexto _context;

        public OrdemController(Contexto context)
        {
            _context = context;
        }

        // GET: Ordem
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ordens.ToListAsync());
        }

        // GET: Ordem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordem = await _context.Ordens
                .FirstOrDefaultAsync(m => m.id == id);
            if (ordem == null)
            {
                return NotFound();
            }

            return View(ordem);
        }

        // GET: Ordem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ordem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,proprietario,cpf,celular,endereco,defeito")] Ordem ordem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordem);
        }

        // GET: Ordem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordem = await _context.Ordens.FindAsync(id);
            if (ordem == null)
            {
                return NotFound();
            }
            return View(ordem);
        }

        // POST: Ordem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,proprietario,cpf,celular,endereco,defeito")] Ordem ordem)
        {
            if (id != ordem.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdemExists(ordem.id))
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
            return View(ordem);
        }

        // GET: Ordem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordem = await _context.Ordens
                .FirstOrDefaultAsync(m => m.id == id);
            if (ordem == null)
            {
                return NotFound();
            }

            return View(ordem);
        }

        // POST: Ordem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordem = await _context.Ordens.FindAsync(id);
            _context.Ordens.Remove(ordem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdemExists(int id)
        {
            return _context.Ordens.Any(e => e.id == id);
        }
    }
}

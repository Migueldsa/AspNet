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
    public class EstoqueOrdemController : Controller
    {
        private readonly Contexto _context;

        public EstoqueOrdemController(Contexto context)
        {
            _context = context;
        }

        // GET: EstoqueOrdem
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstoqueOrdens.ToListAsync());
        }

        // GET: EstoqueOrdem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoqueOrdem = await _context.EstoqueOrdens
                .FirstOrDefaultAsync(m => m.id == id);
            if (estoqueOrdem == null)
            {
                return NotFound();
            }

            return View(estoqueOrdem);
        }

        // GET: EstoqueOrdem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstoqueOrdem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] EstoqueOrdem estoqueOrdem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estoqueOrdem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estoqueOrdem);
        }

        // GET: EstoqueOrdem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoqueOrdem = await _context.EstoqueOrdens.FindAsync(id);
            if (estoqueOrdem == null)
            {
                return NotFound();
            }
            return View(estoqueOrdem);
        }

        // POST: EstoqueOrdem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] EstoqueOrdem estoqueOrdem)
        {
            if (id != estoqueOrdem.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estoqueOrdem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstoqueOrdemExists(estoqueOrdem.id))
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
            return View(estoqueOrdem);
        }

        // GET: EstoqueOrdem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoqueOrdem = await _context.EstoqueOrdens
                .FirstOrDefaultAsync(m => m.id == id);
            if (estoqueOrdem == null)
            {
                return NotFound();
            }

            return View(estoqueOrdem);
        }

        // POST: EstoqueOrdem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estoqueOrdem = await _context.EstoqueOrdens.FindAsync(id);
            _context.EstoqueOrdens.Remove(estoqueOrdem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstoqueOrdemExists(int id)
        {
            return _context.EstoqueOrdens.Any(e => e.id == id);
        }
    }
}

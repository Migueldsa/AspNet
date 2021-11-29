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
    public class CustoController : Controller
    {
        private readonly Contexto _context;

        public CustoController(Contexto context)
        {
            _context = context;
        }

        // GET: Custo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Custos.ToListAsync());
        }

        // GET: Custo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custo = await _context.Custos
                .FirstOrDefaultAsync(m => m.id == id);
            if (custo == null)
            {
                return NotFound();
            }

            return View(custo);
        }

        // GET: Custo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Custo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,mobra,vfornecedor,dias,problema")] Custo custo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(custo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(custo);
        }

        // GET: Custo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custo = await _context.Custos.FindAsync(id);
            if (custo == null)
            {
                return NotFound();
            }
            return View(custo);
        }

        // POST: Custo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,mobra,vfornecedor,dias,problema")] Custo custo)
        {
            if (id != custo.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(custo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustoExists(custo.id))
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
            return View(custo);
        }

        // GET: Custo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custo = await _context.Custos
                .FirstOrDefaultAsync(m => m.id == id);
            if (custo == null)
            {
                return NotFound();
            }

            return View(custo);
        }

        // POST: Custo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var custo = await _context.Custos.FindAsync(id);
            _context.Custos.Remove(custo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustoExists(int id)
        {
            return _context.Custos.Any(e => e.id == id);
        }
    }
}

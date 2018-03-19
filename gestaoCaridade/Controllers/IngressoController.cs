using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gestaoCaridade.Models;

namespace gestaoCaridade.Controllers
{
    public class IngressoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public IngressoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: Ingresso
        public async Task<IActionResult> Index()
        {
            var gestaoCaridadeContext = _context.Ingresso.Include(i => i.EventoIngresso).Include(i => i.VendedorResponsavel);
            return View(await gestaoCaridadeContext.ToListAsync());
        }

        // GET: Ingresso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingresso = await _context.Ingresso
                .Include(i => i.EventoIngresso)
                .Include(i => i.VendedorResponsavel)
                .SingleOrDefaultAsync(m => m.IdIngresso == id);
            if (ingresso == null)
            {
                return NotFound();
            }

            return View(ingresso);
        }

        // GET: Ingresso/Create
        public IActionResult Create()
        {
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome");
            ViewData["IdVendedor"] = new SelectList(_context.Vendedor, "IdVendedor", "Nome");
            return View();
        }

        // POST: Ingresso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdIngresso,Valor,DataVenda,IdVendedor,IdEvento")] Ingresso ingresso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ingresso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", ingresso.IdEvento);
            ViewData["IdVendedor"] = new SelectList(_context.Vendedor, "IdVendedor", "Nome", ingresso.IdVendedor);
            return View(ingresso);
        }

        // GET: Ingresso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingresso = await _context.Ingresso.SingleOrDefaultAsync(m => m.IdIngresso == id);
            if (ingresso == null)
            {
                return NotFound();
            }
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", ingresso.IdEvento);
            ViewData["IdVendedor"] = new SelectList(_context.Vendedor, "IdVendedor", "Nome", ingresso.IdVendedor);
            return View(ingresso);
        }

        // POST: Ingresso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdIngresso,Valor,DataVenda,IdVendedor,IdEvento")] Ingresso ingresso)
        {
            if (id != ingresso.IdIngresso)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingresso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngressoExists(ingresso.IdIngresso))
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
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", ingresso.IdEvento);
            ViewData["IdVendedor"] = new SelectList(_context.Vendedor, "IdVendedor", "Nome", ingresso.IdVendedor);
            return View(ingresso);
        }

        // GET: Ingresso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingresso = await _context.Ingresso
                .Include(i => i.EventoIngresso)
                .Include(i => i.VendedorResponsavel)
                .SingleOrDefaultAsync(m => m.IdIngresso == id);
            if (ingresso == null)
            {
                return NotFound();
            }

            return View(ingresso);
        }

        // POST: Ingresso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ingresso = await _context.Ingresso.SingleOrDefaultAsync(m => m.IdIngresso == id);
            _context.Ingresso.Remove(ingresso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IngressoExists(int id)
        {
            return _context.Ingresso.Any(e => e.IdIngresso == id);
        }
    }
}

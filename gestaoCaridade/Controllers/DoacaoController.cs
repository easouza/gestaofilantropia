using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gestaoCaridade.Models;
using Microsoft.AspNetCore.Authorization;

namespace gestaoCaridade.Controllers
{
    [Authorize]
    public class DoacaoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public DoacaoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: Doacao
        public async Task<IActionResult> Index()
        {
            var gestaoCaridadeContext = _context.Doacao.Include(d => d.DoadorSelecionado).Include(d => d.EventoSelecionado);
            return View(await gestaoCaridadeContext.ToListAsync());
        }

        // GET: Doacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacao
                .Include(d => d.DoadorSelecionado)
                .Include(d => d.EventoSelecionado)
                .SingleOrDefaultAsync(m => m.IdDoacao == id);
            if (doacao == null)
            {
                return NotFound();
            }

            return View(doacao);
        }

        // GET: Doacao/Create
        public IActionResult Create()
        {
            ViewData["IdDoador"] = new SelectList(_context.Doador, "IdDoador", "Nome");
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome");
            return View();
        }

        // POST: Doacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDoacao,Valor,Data,Tipo,Origem,IdDoador,IdEvento")] Doacao doacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDoador"] = new SelectList(_context.Doador, "IdDoador", "Nome", doacao.IdDoador);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", doacao.IdEvento);
            return View(doacao);
        }

        // GET: Doacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacao.SingleOrDefaultAsync(m => m.IdDoacao == id);
            if (doacao == null)
            {
                return NotFound();
            }
            ViewData["IdDoador"] = new SelectList(_context.Doador, "IdDoador", "Nome", doacao.IdDoador);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", doacao.IdEvento);
            return View(doacao);
        }

        // POST: Doacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDoacao,Valor,Data,Tipo,Origem,IdDoador,IdEvento")] Doacao doacao)
        {
            if (id != doacao.IdDoacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoacaoExists(doacao.IdDoacao))
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
            ViewData["IdDoador"] = new SelectList(_context.Doador, "IdDoador", "Nome", doacao.IdDoador);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", doacao.IdEvento);
            return View(doacao);
        }

        // GET: Doacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacao
                .Include(d => d.DoadorSelecionado)
                .Include(d => d.EventoSelecionado)
                .SingleOrDefaultAsync(m => m.IdDoacao == id);
            if (doacao == null)
            {
                return NotFound();
            }

            return View(doacao);
        }

        // POST: Doacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doacao = await _context.Doacao.SingleOrDefaultAsync(m => m.IdDoacao == id);
            _context.Doacao.Remove(doacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoacaoExists(int id)
        {
            return _context.Doacao.Any(e => e.IdDoacao == id);
        }
    }
}

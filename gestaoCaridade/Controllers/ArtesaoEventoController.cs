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
    public class ArtesaoEventoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public ArtesaoEventoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: ArtesaoEvento
        public async Task<IActionResult> Index()
        {
            var gestaoCaridadeContext = _context.ArtesaoEvento.Include(a => a.ArtesaoSelecionado).Include(a => a.EventoVinculado);
            return View(await gestaoCaridadeContext.ToListAsync());
        }

        // GET: ArtesaoEvento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artesaoEvento = await _context.ArtesaoEvento
                .Include(a => a.ArtesaoSelecionado)
                .Include(a => a.EventoVinculado)
                .SingleOrDefaultAsync(m => m.IdArtesaoEvento == id);
            if (artesaoEvento == null)
            {
                return NotFound();
            }

            return View(artesaoEvento);
        }

        // GET: ArtesaoEvento/Create
        public IActionResult Create()
        {
            ViewData["IdArtesao"] = new SelectList(_context.Artesao, "IdArtesao", "Nome");
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome");
            return View();
        }

        // POST: ArtesaoEvento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdArtesaoEvento,IdArtesao,IdEvento,ValorVendido,ComissaoArtesao")] ArtesaoEvento artesaoEvento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artesaoEvento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdArtesao"] = new SelectList(_context.Artesao, "IdArtesao", "Nome", artesaoEvento.IdArtesao);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", artesaoEvento.IdEvento);
            return View(artesaoEvento);
        }

        // GET: ArtesaoEvento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artesaoEvento = await _context.ArtesaoEvento.SingleOrDefaultAsync(m => m.IdArtesaoEvento == id);
            if (artesaoEvento == null)
            {
                return NotFound();
            }
            ViewData["IdArtesao"] = new SelectList(_context.Artesao, "IdArtesao", "Nome", artesaoEvento.IdArtesao);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", artesaoEvento.IdEvento);
            return View(artesaoEvento);
        }

        // POST: ArtesaoEvento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdArtesaoEvento,IdArtesao,IdEvento,ValorVendido,ComissaoArtesao")] ArtesaoEvento artesaoEvento)
        {
            if (id != artesaoEvento.IdArtesaoEvento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artesaoEvento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtesaoEventoExists(artesaoEvento.IdArtesaoEvento))
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
            ViewData["IdArtesao"] = new SelectList(_context.Artesao, "IdArtesao", "Nome", artesaoEvento.IdArtesao);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", artesaoEvento.IdEvento);
            return View(artesaoEvento);
        }

        // GET: ArtesaoEvento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artesaoEvento = await _context.ArtesaoEvento
                .Include(a => a.ArtesaoSelecionado)
                .Include(a => a.EventoVinculado)
                .SingleOrDefaultAsync(m => m.IdArtesaoEvento == id);
            if (artesaoEvento == null)
            {
                return NotFound();
            }

            return View(artesaoEvento);
        }

        // POST: ArtesaoEvento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artesaoEvento = await _context.ArtesaoEvento.SingleOrDefaultAsync(m => m.IdArtesaoEvento == id);
            _context.ArtesaoEvento.Remove(artesaoEvento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtesaoEventoExists(int id)
        {
            return _context.ArtesaoEvento.Any(e => e.IdArtesaoEvento == id);
        }
    }
}

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
    public class DocumentoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public DocumentoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: Documento
        public async Task<IActionResult> Index()
        {
            return View(await _context.Documento.ToListAsync());
        }

        // GET: Documento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documento = await _context.Documento
                .SingleOrDefaultAsync(m => m.IdDocumento == id);
            if (documento == null)
            {
                return NotFound();
            }

            return View(documento);
        }

        // GET: Documento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Documento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDocumento,Nome,DataInsercao,DataAtualizacao")] Documento documento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(documento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(documento);
        }

        // GET: Documento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documento = await _context.Documento.SingleOrDefaultAsync(m => m.IdDocumento == id);
            if (documento == null)
            {
                return NotFound();
            }
            return View(documento);
        }

        // POST: Documento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDocumento,Nome,DataInsercao,DataAtualizacao")] Documento documento)
        {
            if (id != documento.IdDocumento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(documento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentoExists(documento.IdDocumento))
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
            return View(documento);
        }

        // GET: Documento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documento = await _context.Documento
                .SingleOrDefaultAsync(m => m.IdDocumento == id);
            if (documento == null)
            {
                return NotFound();
            }

            return View(documento);
        }

        // POST: Documento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var documento = await _context.Documento.SingleOrDefaultAsync(m => m.IdDocumento == id);
            _context.Documento.Remove(documento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentoExists(int id)
        {
            return _context.Documento.Any(e => e.IdDocumento == id);
        }
    }
}

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
    public class CaridadeController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public CaridadeController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: Caridade
        public async Task<IActionResult> Index()
        {
            var gestaoCaridadeContext = _context.Caridade.Include(c => c.BeneficiadoSelecionado).Include(c => c.ItemSelecionado);
            return View(await gestaoCaridadeContext.ToListAsync());
        }

        // GET: Caridade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caridade = await _context.Caridade
                .Include(c => c.BeneficiadoSelecionado)
                .Include(c => c.ItemSelecionado)
                .SingleOrDefaultAsync(m => m.IdCaridade == id);
            if (caridade == null)
            {
                return NotFound();
            }

            return View(caridade);
        }

        // GET: Caridade/Create
        public IActionResult Create()
        {
            ViewData["IdBeneficiado"] = new SelectList(_context.Beneficiado, "IDBeneficiado", "Nome");
            ViewData["IdItem"] = new SelectList(_context.Item, "IdItem", "Tipo");
            return View();
        }

        // POST: Caridade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCaridade,Data,Endereco,IdBeneficiado,IdItem")] Caridade caridade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caridade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdBeneficiado"] = new SelectList(_context.Beneficiado, "IDBeneficiado", "Nome", caridade.IdBeneficiado);
            ViewData["IdItem"] = new SelectList(_context.Item, "IdItem", "Tipo", caridade.IdItem);
            return View(caridade);
        }

        // GET: Caridade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caridade = await _context.Caridade.SingleOrDefaultAsync(m => m.IdCaridade == id);
            if (caridade == null)
            {
                return NotFound();
            }
            ViewData["IdBeneficiado"] = new SelectList(_context.Beneficiado, "IDBeneficiado", "Nome", caridade.IdBeneficiado);
            ViewData["IdItem"] = new SelectList(_context.Item, "IdItem", "Tipo", caridade.IdItem);
            return View(caridade);
        }

        // POST: Caridade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCaridade,Data,Endereco,IdBeneficiado,IdItem")] Caridade caridade)
        {
            if (id != caridade.IdCaridade)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caridade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaridadeExists(caridade.IdCaridade))
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
            ViewData["IdBeneficiado"] = new SelectList(_context.Beneficiado, "IDBeneficiado", "Nome", caridade.IdBeneficiado);
            ViewData["IdItem"] = new SelectList(_context.Item, "IdItem", "Tipo", caridade.IdItem);
            return View(caridade);
        }

        // GET: Caridade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caridade = await _context.Caridade
                .Include(c => c.BeneficiadoSelecionado)
                .Include(c => c.ItemSelecionado)
                .SingleOrDefaultAsync(m => m.IdCaridade == id);
            if (caridade == null)
            {
                return NotFound();
            }

            return View(caridade);
        }

        // POST: Caridade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caridade = await _context.Caridade.SingleOrDefaultAsync(m => m.IdCaridade == id);
            _context.Caridade.Remove(caridade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaridadeExists(int id)
        {
            return _context.Caridade.Any(e => e.IdCaridade == id);
        }
    }
}

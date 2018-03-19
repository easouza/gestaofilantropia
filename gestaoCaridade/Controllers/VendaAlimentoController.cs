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
    public class VendaAlimentoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public VendaAlimentoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: VendaAlimento
        public async Task<IActionResult> Index()
        {
            return View(await _context.VendaAlimento.ToListAsync());
        }

        // GET: VendaAlimento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaAlimento = await _context.VendaAlimento
                .SingleOrDefaultAsync(m => m.IdVendaAlimento == id);
            if (vendaAlimento == null)
            {
                return NotFound();
            }

            return View(vendaAlimento);
        }

        // GET: VendaAlimento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendaAlimento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVendaAlimento,Valor,Data,Tipo")] VendaAlimento vendaAlimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendaAlimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendaAlimento);
        }

        // GET: VendaAlimento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaAlimento = await _context.VendaAlimento.SingleOrDefaultAsync(m => m.IdVendaAlimento == id);
            if (vendaAlimento == null)
            {
                return NotFound();
            }
            return View(vendaAlimento);
        }

        // POST: VendaAlimento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVendaAlimento,Valor,Data,Tipo")] VendaAlimento vendaAlimento)
        {
            if (id != vendaAlimento.IdVendaAlimento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendaAlimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaAlimentoExists(vendaAlimento.IdVendaAlimento))
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
            return View(vendaAlimento);
        }

        // GET: VendaAlimento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaAlimento = await _context.VendaAlimento
                .SingleOrDefaultAsync(m => m.IdVendaAlimento == id);
            if (vendaAlimento == null)
            {
                return NotFound();
            }

            return View(vendaAlimento);
        }

        // POST: VendaAlimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendaAlimento = await _context.VendaAlimento.SingleOrDefaultAsync(m => m.IdVendaAlimento == id);
            _context.VendaAlimento.Remove(vendaAlimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaAlimentoExists(int id)
        {
            return _context.VendaAlimento.Any(e => e.IdVendaAlimento == id);
        }
    }
}

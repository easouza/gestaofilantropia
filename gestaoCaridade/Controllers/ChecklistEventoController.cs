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
    public class ChecklistEventoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public ChecklistEventoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: ChecklistEvento
        public async Task<IActionResult> Index()
        {
            var gestaoCaridadeContext = _context.ChecklistEvento.Include(c => c.EventoVinculado);
            return View(await gestaoCaridadeContext.ToListAsync());
        }

        // GET: ChecklistEvento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checklistEvento = await _context.ChecklistEvento
                .Include(c => c.EventoVinculado)
                .SingleOrDefaultAsync(m => m.IDChecklist == id);
            if (checklistEvento == null)
            {
                return NotFound();
            }

            return View(checklistEvento);
        }

        // GET: ChecklistEvento/Create
        public IActionResult Create()
        {
            ViewData["IDEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome");
            return View();
        }

        // POST: ChecklistEvento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDChecklist,IDEvento,ReservaLocal")] ChecklistEvento checklistEvento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(checklistEvento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", checklistEvento.IDEvento);
            return View(checklistEvento);
        }

        // GET: ChecklistEvento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checklistEvento = await _context.ChecklistEvento.SingleOrDefaultAsync(m => m.IDChecklist == id);
            if (checklistEvento == null)
            {
                return NotFound();
            }
            ViewData["IDEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", checklistEvento.IDEvento);
            return View(checklistEvento);
        }

        // POST: ChecklistEvento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDChecklist,IDEvento,ReservaLocal")] ChecklistEvento checklistEvento)
        {
            if (id != checklistEvento.IDChecklist)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(checklistEvento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChecklistEventoExists(checklistEvento.IDChecklist))
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
            ViewData["IDEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", checklistEvento.IDEvento);
            return View(checklistEvento);
        }

        // GET: ChecklistEvento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checklistEvento = await _context.ChecklistEvento
                .Include(c => c.EventoVinculado)
                .SingleOrDefaultAsync(m => m.IDChecklist == id);
            if (checklistEvento == null)
            {
                return NotFound();
            }

            return View(checklistEvento);
        }

        // POST: ChecklistEvento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var checklistEvento = await _context.ChecklistEvento.SingleOrDefaultAsync(m => m.IDChecklist == id);
            _context.ChecklistEvento.Remove(checklistEvento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChecklistEventoExists(int id)
        {
            return _context.ChecklistEvento.Any(e => e.IDChecklist == id);
        }
    }
}

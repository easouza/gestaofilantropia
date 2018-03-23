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
    public class EventoClienteController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public EventoClienteController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: EventoCliente
        public async Task<IActionResult> Index()
        {
            var gestaoCaridadeContext = _context.EventoCliente.Include(e => e.ClienteSelecionado).Include(e => e.EventoSelecionado);
            return View(await gestaoCaridadeContext.ToListAsync());
        }

        // GET: EventoCliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoCliente = await _context.EventoCliente
                .Include(e => e.ClienteSelecionado)
                .Include(e => e.EventoSelecionado)
                .SingleOrDefaultAsync(m => m.IdEventoCliente == id);
            if (eventoCliente == null)
            {
                return NotFound();
            }

            return View(eventoCliente);
        }

        // GET: EventoCliente/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Nome");
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome");
            return View();
        }

        // POST: EventoCliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEventoCliente,IdCliente,IdEvento")] EventoCliente eventoCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventoCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Nome", eventoCliente.IdCliente);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", eventoCliente.IdEvento);
            return View(eventoCliente);
        }

        // GET: EventoCliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoCliente = await _context.EventoCliente.SingleOrDefaultAsync(m => m.IdEventoCliente == id);
            if (eventoCliente == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Nome", eventoCliente.IdCliente);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", eventoCliente.IdEvento);
            return View(eventoCliente);
        }

        // POST: EventoCliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEventoCliente,IdCliente,IdEvento")] EventoCliente eventoCliente)
        {
            if (id != eventoCliente.IdEventoCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventoCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventoClienteExists(eventoCliente.IdEventoCliente))
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
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Nome", eventoCliente.IdCliente);
            ViewData["IdEvento"] = new SelectList(_context.Evento, "IdEvento", "Nome", eventoCliente.IdEvento);
            return View(eventoCliente);
        }

        // GET: EventoCliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoCliente = await _context.EventoCliente
                .Include(e => e.ClienteSelecionado)
                .Include(e => e.EventoSelecionado)
                .SingleOrDefaultAsync(m => m.IdEventoCliente == id);
            if (eventoCliente == null)
            {
                return NotFound();
            }

            return View(eventoCliente);
        }

        // POST: EventoCliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventoCliente = await _context.EventoCliente.SingleOrDefaultAsync(m => m.IdEventoCliente == id);
            _context.EventoCliente.Remove(eventoCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventoClienteExists(int id)
        {
            return _context.EventoCliente.Any(e => e.IdEventoCliente == id);
        }
    }
}

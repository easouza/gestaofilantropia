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
    public class BeneficiadoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public BeneficiadoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: Beneficiado
        public async Task<IActionResult> Index()
        {
            return View(await _context.Beneficiado.ToListAsync());
        }

        // GET: Beneficiado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beneficiado = await _context.Beneficiado
                .SingleOrDefaultAsync(m => m.IDBeneficiado == id);
            if (beneficiado == null)
            {
                return NotFound();
            }

            return View(beneficiado);
        }

        // GET: Beneficiado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Beneficiado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDBeneficiado,Nome,Endereco,Telefone,DataNascimento")] Beneficiado beneficiado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beneficiado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(beneficiado);
        }

        // GET: Beneficiado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beneficiado = await _context.Beneficiado.SingleOrDefaultAsync(m => m.IDBeneficiado == id);
            if (beneficiado == null)
            {
                return NotFound();
            }
            return View(beneficiado);
        }

        // POST: Beneficiado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDBeneficiado,Nome,Endereco,Telefone,DataNascimento")] Beneficiado beneficiado)
        {
            if (id != beneficiado.IDBeneficiado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beneficiado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BeneficiadoExists(beneficiado.IDBeneficiado))
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
            return View(beneficiado);
        }

        // GET: Beneficiado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beneficiado = await _context.Beneficiado
                .SingleOrDefaultAsync(m => m.IDBeneficiado == id);
            if (beneficiado == null)
            {
                return NotFound();
            }

            return View(beneficiado);
        }

        // POST: Beneficiado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var beneficiado = await _context.Beneficiado.SingleOrDefaultAsync(m => m.IDBeneficiado == id);
            _context.Beneficiado.Remove(beneficiado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BeneficiadoExists(int id)
        {
            return _context.Beneficiado.Any(e => e.IDBeneficiado == id);
        }
    }
}

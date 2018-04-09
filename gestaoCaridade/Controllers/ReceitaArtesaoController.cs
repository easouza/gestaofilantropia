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
    public class ReceitaArtesaoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public ReceitaArtesaoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: ReceitaArtesao
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReceitaArtesao.ToListAsync());
        }

        // GET: ReceitaArtesao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receitaArtesao = await _context.ReceitaArtesao
                .SingleOrDefaultAsync(m => m.IdReceitaArtesao == id);
            if (receitaArtesao == null)
            {
                return NotFound();
            }

            return View(receitaArtesao);
        }

        // GET: ReceitaArtesao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReceitaArtesao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReceitaArtesao,Valor,Comissao")] ReceitaArtesao receitaArtesao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(receitaArtesao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(receitaArtesao);
        }

        // GET: ReceitaArtesao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receitaArtesao = await _context.ReceitaArtesao.SingleOrDefaultAsync(m => m.IdReceitaArtesao == id);
            if (receitaArtesao == null)
            {
                return NotFound();
            }
            return View(receitaArtesao);
        }

        // POST: ReceitaArtesao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdReceitaArtesao,Valor,Comissao")] ReceitaArtesao receitaArtesao)
        {
            if (id != receitaArtesao.IdReceitaArtesao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receitaArtesao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceitaArtesaoExists(receitaArtesao.IdReceitaArtesao))
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
            return View(receitaArtesao);
        }

        // GET: ReceitaArtesao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receitaArtesao = await _context.ReceitaArtesao
                .SingleOrDefaultAsync(m => m.IdReceitaArtesao == id);
            if (receitaArtesao == null)
            {
                return NotFound();
            }

            return View(receitaArtesao);
        }

        // POST: ReceitaArtesao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receitaArtesao = await _context.ReceitaArtesao.SingleOrDefaultAsync(m => m.IdReceitaArtesao == id);
            _context.ReceitaArtesao.Remove(receitaArtesao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceitaArtesaoExists(int id)
        {
            return _context.ReceitaArtesao.Any(e => e.IdReceitaArtesao == id);
        }
    }
}

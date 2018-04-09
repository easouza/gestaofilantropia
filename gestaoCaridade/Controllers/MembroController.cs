using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gestaoCaridade.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace gestaoCaridade.Controllers
{
    [Authorize]
    public class MembroController : Controller
    {
        private readonly gestaoCaridadeContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public MembroController(gestaoCaridadeContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Membro
        public async Task<IActionResult> Index()
        {
            return View(await _context.Responsavel.ToListAsync());
        }

        // GET: Membro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Responsavel
                .SingleOrDefaultAsync(m => m.IdMembro == id);
            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // GET: Membro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Membro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMembro,Nome,UserName,Cargo,DataEntrada,DataNascimento,Endereco,Telefone,Password")] Membro membro)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = membro.UserName };
                var result = await _userManager.CreateAsync(user, membro.Password);
                if (result.Succeeded)
                {
                    _context.Add(membro);
                    await _context.SaveChangesAsync();
                }
            }
            return View(membro);
        }

        // GET: Membro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Responsavel.SingleOrDefaultAsync(m => m.IdMembro == id);
            if (membro == null)
            {
                return NotFound();
            }
            return View(membro);
        }

        // POST: Membro/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMembro,Nome,Cargo,DataEntrada,DataNascimento,Endereco,Telefone,Password")] Membro membro)
        {
            if (id != membro.IdMembro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembroExists(membro.IdMembro))
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
            return View(membro);
        }

        // GET: Membro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Responsavel
                .SingleOrDefaultAsync(m => m.IdMembro == id);
            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // POST: Membro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var membro = await _context.Responsavel.SingleOrDefaultAsync(m => m.IdMembro == id);
            _context.Responsavel.Remove(membro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembroExists(int id)
        {
            return _context.Responsavel.Any(e => e.IdMembro == id);
        }
    }
}

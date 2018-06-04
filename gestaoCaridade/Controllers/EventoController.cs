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
    public class EventoController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public EventoController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        // GET: Evento
        public async Task<IActionResult> Index(string Nome, string Tipo)
        {
            var gestaoCaridadeContext = _context.Evento.Include(e => e.ResponsavelBebidas).Include(e => e.ResponsavelCaixas).Include(e => e.ResponsavelCozinha).Include(e => e.ResponsavelLimpeza).Include(e => e.ResponsavelLixo).Include(e => e.ResponsavelMesa).Include(e => e.ResponsavelPalco).Include(e => e.ResponsavelSeguranca);
            if (!String.IsNullOrEmpty(Nome))
            {
                gestaoCaridadeContext = _context.Evento.Where(s => s.Nome.Contains(Nome)).Include(e => e.ResponsavelBebidas).Include(e => e.ResponsavelCaixas).Include(e => e.ResponsavelCozinha).Include(e => e.ResponsavelLimpeza).Include(e => e.ResponsavelLixo).Include(e => e.ResponsavelMesa).Include(e => e.ResponsavelPalco).Include(e => e.ResponsavelSeguranca);
            }

            if (!String.IsNullOrEmpty(Tipo))
            {
                gestaoCaridadeContext = gestaoCaridadeContext.Where(s => s.Tipo.Contains(Tipo)).Include(e => e.ResponsavelBebidas).Include(e => e.ResponsavelCaixas).Include(e => e.ResponsavelCozinha).Include(e => e.ResponsavelLimpeza).Include(e => e.ResponsavelLixo).Include(e => e.ResponsavelMesa).Include(e => e.ResponsavelPalco).Include(e => e.ResponsavelSeguranca);
            }

            return View(await gestaoCaridadeContext.ToListAsync());
        }

        // GET: Evento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento = await _context.Evento
                .Include(e => e.ResponsavelBebidas)
                .Include(e => e.ResponsavelCaixas)
                .Include(e => e.ResponsavelCozinha)
                .Include(e => e.ResponsavelLimpeza)
                .Include(e => e.ResponsavelLixo)
                .Include(e => e.ResponsavelMesa)
                .Include(e => e.ResponsavelPalco)
                .Include(e => e.ResponsavelSeguranca)
                .SingleOrDefaultAsync(m => m.IdEvento == id);
            if (evento == null)
            {
                return NotFound();
            }

            return View(evento);
        }

        // GET: Evento/Create
        public IActionResult Create()
        {
            ViewData["idResponsavelBebidas"] = new SelectList(_context.Responsavel, "IdMembro", "Nome");
            ViewData["idResponsavelCaixas"] = new SelectList(_context.Responsavel, "IdMembro", "Nome");
            ViewData["idResponsavelCozinha"] = new SelectList(_context.Responsavel, "IdMembro", "Nome");
            ViewData["idResponsavelLimpeza"] = new SelectList(_context.Responsavel, "IdMembro", "Nome");
            ViewData["idResponsavelLixo"] = new SelectList(_context.Responsavel, "IdMembro", "Nome");
            ViewData["idResponsavelMesa"] = new SelectList(_context.Responsavel, "IdMembro", "Nome");
            ViewData["idResponsavelPalco"] = new SelectList(_context.Responsavel, "IdMembro", "Nome");
            ViewData["idResponsavelSeguranca"] = new SelectList(_context.Responsavel, "IdMembro", "Nome");
            return View();
        }

        // POST: Evento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEvento,Nome,Tipo,Local,Data,idResponsavelMesa,idResponsavelPalco,idResponsavelCozinha,idResponsavelBebidas,idResponsavelCaixas,idResponsavelLixo,idResponsavelSeguranca,idResponsavelLimpeza,ClubeAgendado,ConfirmarNumeroMesas,VerificaCozinha,ConfirmarFuncionarios,ConfeccionarConvites,FazerCartaPedidos,EntregarConvites,FazerCartaAgradecimento,FazerCartaBetheisDemolays,ComprarCartela,NumerarCartela,CarimbarCartela,ContratarSom,ContratarSegurancas,ProvidenciarRoleta,SepararFichas,LevarTroco,ProvidenciarCaixaDinheiro,ProvidenciarVasilha,ProvidenciarPratinhos,ProvidenciarPratosGarfos,ProvidenciarCoposColheres,ProvidenciarLapis,ProvidenciarGuardanapos,ProvidenciarPanodePrato,ProvidenciarPerfex,ProvidenciarFosforo,ProvidenciarBuchinha,ProvidenciarPapelHigienico,ProvidenciarToalhaMesa,ProvidenciarSacoLixo,ProvidenciarCestaBebida,ProvidenciarBandejas,ProvidenciarCrachas,ProvidenciarBloquinho,ProvidenciarBebidas,ProvidenciarComidas,FazerCardapio,FazerAgradecimento,FazerListaBrindes,ComparPlasticoEmbalar,FazerValeTicket,FazerEscala,MarcarHorarioChegada")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idResponsavelBebidas"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelBebidas);
            ViewData["idResponsavelCaixas"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelCaixas);
            ViewData["idResponsavelCozinha"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelCozinha);
            ViewData["idResponsavelLimpeza"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelLimpeza);
            ViewData["idResponsavelLixo"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelLixo);
            ViewData["idResponsavelMesa"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelMesa);
            ViewData["idResponsavelPalco"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelPalco);
            ViewData["idResponsavelSeguranca"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelSeguranca);
            return View(evento);
        }

        // GET: Evento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento = await _context.Evento.SingleOrDefaultAsync(m => m.IdEvento == id);
            if (evento == null)
            {
                return NotFound();
            }
            ViewData["idResponsavelBebidas"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelBebidas);
            ViewData["idResponsavelCaixas"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelCaixas);
            ViewData["idResponsavelCozinha"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelCozinha);
            ViewData["idResponsavelLimpeza"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelLimpeza);
            ViewData["idResponsavelLixo"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelLixo);
            ViewData["idResponsavelMesa"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelMesa);
            ViewData["idResponsavelPalco"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelPalco);
            ViewData["idResponsavelSeguranca"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelSeguranca);
            return View(evento);
        }

        // POST: Evento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEvento,Nome,Tipo,Local,Data,idResponsavelMesa,idResponsavelPalco,idResponsavelCozinha,idResponsavelBebidas,idResponsavelCaixas,idResponsavelLixo,idResponsavelSeguranca,idResponsavelLimpeza,ClubeAgendado,ConfirmarNumeroMesas,VerificaCozinha,ConfirmarFuncionarios,ConfeccionarConvites,FazerCartaPedidos,EntregarConvites,FazerCartaAgradecimento,FazerCartaBetheisDemolays,ComprarCartela,NumerarCartela,CarimbarCartela,ContratarSom,ContratarSegurancas,ProvidenciarRoleta,SepararFichas,LevarTroco,ProvidenciarCaixaDinheiro,ProvidenciarVasilha,ProvidenciarPratinhos,ProvidenciarPratosGarfos,ProvidenciarCoposColheres,ProvidenciarLapis,ProvidenciarGuardanapos,ProvidenciarPanodePrato,ProvidenciarPerfex,ProvidenciarFosforo,ProvidenciarBuchinha,ProvidenciarPapelHigienico,ProvidenciarToalhaMesa,ProvidenciarSacoLixo,ProvidenciarCestaBebida,ProvidenciarBandejas,ProvidenciarCrachas,ProvidenciarBloquinho,ProvidenciarBebidas,ProvidenciarComidas,FazerCardapio,FazerAgradecimento,FazerListaBrindes,ComparPlasticoEmbalar,FazerValeTicket,FazerEscala,MarcarHorarioChegada")] Evento evento)
        {
            if (id != evento.IdEvento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(evento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventoExists(evento.IdEvento))
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
            ViewData["idResponsavelBebidas"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelBebidas);
            ViewData["idResponsavelCaixas"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelCaixas);
            ViewData["idResponsavelCozinha"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelCozinha);
            ViewData["idResponsavelLimpeza"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelLimpeza);
            ViewData["idResponsavelLixo"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelLixo);
            ViewData["idResponsavelMesa"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelMesa);
            ViewData["idResponsavelPalco"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelPalco);
            ViewData["idResponsavelSeguranca"] = new SelectList(_context.Responsavel, "IdMembro", "Nome", evento.idResponsavelSeguranca);
            return View(evento);
        }

        // GET: Evento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento = await _context.Evento
                .Include(e => e.ResponsavelBebidas)
                .Include(e => e.ResponsavelCaixas)
                .Include(e => e.ResponsavelCozinha)
                .Include(e => e.ResponsavelLimpeza)
                .Include(e => e.ResponsavelLixo)
                .Include(e => e.ResponsavelMesa)
                .Include(e => e.ResponsavelPalco)
                .Include(e => e.ResponsavelSeguranca)
                .SingleOrDefaultAsync(m => m.IdEvento == id);
            if (evento == null)
            {
                return NotFound();
            }

            return View(evento);
        }

        // POST: Evento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var evento = await _context.Evento.SingleOrDefaultAsync(m => m.IdEvento == id);
            _context.Evento.Remove(evento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventoExists(int id)
        {
            return _context.Evento.Any(e => e.IdEvento == id);
        }
    }
}

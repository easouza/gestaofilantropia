using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gestaoCaridade.Models;
using Microsoft.EntityFrameworkCore;

namespace gestaoCaridade.Controllers
{
    public class HomeController : Controller
    {
        private readonly gestaoCaridadeContext _context;

        public HomeController(gestaoCaridadeContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var gestaoCaridadeContext = _context.Evento.Include(e => e.ResponsavelBebidas).Include(e => e.ResponsavelCaixas).Include(e => e.ResponsavelCozinha).Include(e => e.ResponsavelLimpeza).Include(e => e.ResponsavelLixo).Include(e => e.ResponsavelMesa).Include(e => e.ResponsavelPalco).Include(e => e.ResponsavelSeguranca).Where(e => e.Data >= DateTime.Now);
            return View(await gestaoCaridadeContext.ToListAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

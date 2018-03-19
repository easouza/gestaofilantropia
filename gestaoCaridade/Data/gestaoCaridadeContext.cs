using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gestaoCaridade.Models;

namespace gestaoCaridade.Models
{
    public class gestaoCaridadeContext : DbContext
    {
        public gestaoCaridadeContext (DbContextOptions<gestaoCaridadeContext> options)
            : base(options)
        {
        }

        public DbSet<gestaoCaridade.Models.Evento> Evento { get; set; }

        public DbSet<gestaoCaridade.Models.Artesao> Artesao { get; set; }

        public DbSet<gestaoCaridade.Models.Beneficiado> Beneficiado { get; set; }

        public DbSet<gestaoCaridade.Models.Cliente> Cliente { get; set; }

        public DbSet<gestaoCaridade.Models.Doador> Doador { get; set; }

        public DbSet<gestaoCaridade.Models.Item> Item { get; set; }

        public DbSet<gestaoCaridade.Models.Material> Material { get; set; }

        public DbSet<gestaoCaridade.Models.ReceitaArtesao> ReceitaArtesao { get; set; }

        public DbSet<gestaoCaridade.Models.Responsavel> Responsavel { get; set; }

        public DbSet<gestaoCaridade.Models.VendaAlimento> VendaAlimento { get; set; }

        public DbSet<gestaoCaridade.Models.Vendedor> Vendedor { get; set; }
    }
}

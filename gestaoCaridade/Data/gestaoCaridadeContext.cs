﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gestaoCaridade.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace gestaoCaridade.Models
{
    public class gestaoCaridadeContext : IdentityDbContext<IdentityUser>
    {
        public gestaoCaridadeContext (DbContextOptions<gestaoCaridadeContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var cascadeFKs = builder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;



        }

        public DbSet<gestaoCaridade.Models.Evento> Evento { get; set; }

        public DbSet<gestaoCaridade.Models.Artesao> Artesao { get; set; }

        public DbSet<gestaoCaridade.Models.Beneficiado> Beneficiado { get; set; }

        public DbSet<gestaoCaridade.Models.Cliente> Cliente { get; set; }

        public DbSet<gestaoCaridade.Models.Doador> Doador { get; set; }

        public DbSet<gestaoCaridade.Models.Item> Item { get; set; }

        public DbSet<gestaoCaridade.Models.Material> Material { get; set; }

        public DbSet<gestaoCaridade.Models.ReceitaArtesao> ReceitaArtesao { get; set; }

        public DbSet<gestaoCaridade.Models.Membro> Responsavel { get; set; }

        public DbSet<gestaoCaridade.Models.VendaAlimento> VendaAlimento { get; set; }

        public DbSet<gestaoCaridade.Models.Vendedor> Vendedor { get; set; }

        public DbSet<gestaoCaridade.Models.Ingresso> Ingresso { get; set; }

        public DbSet<gestaoCaridade.Models.Doacao> Doacao { get; set; }

        public DbSet<gestaoCaridade.Models.ArtesaoEvento> ArtesaoEvento { get; set; }

        public DbSet<gestaoCaridade.Models.EventoCliente> EventoCliente { get; set; }

        public DbSet<gestaoCaridade.Models.Caridade> Caridade { get; set; }

        public DbSet<gestaoCaridade.Models.Documento> Documento { get; set; }

        public DbSet<gestaoCaridade.Models.ChecklistEvento> ChecklistEvento { get; set; }
    }
}
﻿// <auto-generated />
using gestaoCaridade.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace gestaoCaridade.Migrations
{
    [DbContext(typeof(gestaoCaridadeContext))]
    [Migration("20180409175600_identity2")]
    partial class identity2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("gestaoCaridade.Models.Artesao", b =>
                {
                    b.Property<int>("IdArtesao")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Profissao")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("IdArtesao");

                    b.ToTable("Artesao");
                });

            modelBuilder.Entity("gestaoCaridade.Models.ArtesaoEvento", b =>
                {
                    b.Property<int>("IdArtesaoEvento")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdArtesao");

                    b.Property<int>("IdEvento");

                    b.HasKey("IdArtesaoEvento");

                    b.HasIndex("IdArtesao");

                    b.HasIndex("IdEvento");

                    b.ToTable("ArtesaoEvento");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Beneficiado", b =>
                {
                    b.Property<int>("IDBeneficiado")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("IDBeneficiado");

                    b.ToTable("Beneficiado");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Caridade", b =>
                {
                    b.Property<int>("IdCaridade")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<string>("Endereco");

                    b.Property<int>("IdBeneficiado");

                    b.Property<int>("IdItem");

                    b.HasKey("IdCaridade");

                    b.HasIndex("IdBeneficiado");

                    b.HasIndex("IdItem");

                    b.ToTable("Caridade");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Doacao", b =>
                {
                    b.Property<int>("IdDoacao")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdDoador");

                    b.Property<int>("IdEvento");

                    b.Property<string>("Origem");

                    b.Property<string>("Tipo");

                    b.Property<double>("Valor");

                    b.HasKey("IdDoacao");

                    b.HasIndex("IdDoador");

                    b.HasIndex("IdEvento");

                    b.ToTable("Doacao");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Doador", b =>
                {
                    b.Property<int>("IdDoador")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataEntrada");

                    b.Property<string>("Endereco");

                    b.Property<string>("Indicacao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("IdDoador");

                    b.ToTable("Doador");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Evento", b =>
                {
                    b.Property<int>("IdEvento")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdMembro");

                    b.Property<string>("Local");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Tipo");

                    b.HasKey("IdEvento");

                    b.HasIndex("IdMembro");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("gestaoCaridade.Models.EventoCliente", b =>
                {
                    b.Property<int>("IdEventoCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdCliente");

                    b.Property<int>("IdEvento");

                    b.HasKey("IdEventoCliente");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEvento");

                    b.ToTable("EventoCliente");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Ingresso", b =>
                {
                    b.Property<int>("IdIngresso")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataVenda");

                    b.Property<int>("IdEvento");

                    b.Property<int>("IdVendedor");

                    b.Property<double>("Valor");

                    b.HasKey("IdIngresso");

                    b.HasIndex("IdEvento");

                    b.HasIndex("IdVendedor");

                    b.ToTable("Ingresso");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Item", b =>
                {
                    b.Property<int>("IdItem")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAquisicao");

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.Property<double>("Valor");

                    b.HasKey("IdItem");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Material", b =>
                {
                    b.Property<int>("IDMaterial")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAquisicao");

                    b.Property<int>("IdEvento");

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.Property<double>("Valor");

                    b.HasKey("IDMaterial");

                    b.HasIndex("IdEvento");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Membro", b =>
                {
                    b.Property<int>("IdMembro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cargo");

                    b.Property<DateTime>("DataEntrada");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("IdMembro");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("gestaoCaridade.Models.ReceitaArtesao", b =>
                {
                    b.Property<int>("IdReceitaArtesao")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Comissao");

                    b.Property<double>("Valor");

                    b.HasKey("IdReceitaArtesao");

                    b.ToTable("ReceitaArtesao");
                });

            modelBuilder.Entity("gestaoCaridade.Models.VendaAlimento", b =>
                {
                    b.Property<int>("IdVendaAlimento")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<string>("Tipo");

                    b.Property<double>("Valor");

                    b.HasKey("IdVendaAlimento");

                    b.ToTable("VendaAlimento");
                });

            modelBuilder.Entity("gestaoCaridade.Models.Vendedor", b =>
                {
                    b.Property<int>("IdVendedor")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataEntrada");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("IdVendedor");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("gestaoCaridade.Models.ArtesaoEvento", b =>
                {
                    b.HasOne("gestaoCaridade.Models.Artesao", "ArtesaoSelecionado")
                        .WithMany()
                        .HasForeignKey("IdArtesao")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gestaoCaridade.Models.Evento", "EventoVinculado")
                        .WithMany()
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gestaoCaridade.Models.Caridade", b =>
                {
                    b.HasOne("gestaoCaridade.Models.Beneficiado", "BeneficiadoSelecionado")
                        .WithMany()
                        .HasForeignKey("IdBeneficiado")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gestaoCaridade.Models.Item", "ItemSelecionado")
                        .WithMany()
                        .HasForeignKey("IdItem")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gestaoCaridade.Models.Doacao", b =>
                {
                    b.HasOne("gestaoCaridade.Models.Doador", "DoadorSelecionado")
                        .WithMany()
                        .HasForeignKey("IdDoador")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gestaoCaridade.Models.Evento", "EventoSelecionado")
                        .WithMany()
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gestaoCaridade.Models.Evento", b =>
                {
                    b.HasOne("gestaoCaridade.Models.Membro", "MembroEvento")
                        .WithMany()
                        .HasForeignKey("IdMembro")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gestaoCaridade.Models.EventoCliente", b =>
                {
                    b.HasOne("gestaoCaridade.Models.Cliente", "ClienteSelecionado")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gestaoCaridade.Models.Evento", "EventoSelecionado")
                        .WithMany()
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gestaoCaridade.Models.Ingresso", b =>
                {
                    b.HasOne("gestaoCaridade.Models.Evento", "EventoIngresso")
                        .WithMany()
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gestaoCaridade.Models.Vendedor", "VendedorResponsavel")
                        .WithMany()
                        .HasForeignKey("IdVendedor")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gestaoCaridade.Models.Material", b =>
                {
                    b.HasOne("gestaoCaridade.Models.Evento", "EventoSelecionado")
                        .WithMany()
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

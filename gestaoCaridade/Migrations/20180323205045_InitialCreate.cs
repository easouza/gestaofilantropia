using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artesao",
                columns: table => new
                {
                    IdArtesao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Profissao = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artesao", x => x.IdArtesao);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiado",
                columns: table => new
                {
                    IDBeneficiado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiado", x => x.IDBeneficiado);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataNascimento = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Doador",
                columns: table => new
                {
                    IdDoador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataEntrada = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doador", x => x.IdDoador);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    IdItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAquisicao = table.Column<DateTime>(nullable: false),
                    Tipo = table.Column<string>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.IdItem);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaArtesao",
                columns: table => new
                {
                    IdReceitaArtesao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comissao = table.Column<double>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaArtesao", x => x.IdReceitaArtesao);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    IdResponsavel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cargo = table.Column<string>(nullable: true),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.IdResponsavel);
                });

            migrationBuilder.CreateTable(
                name: "VendaAlimento",
                columns: table => new
                {
                    IdVendaAlimento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaAlimento", x => x.IdVendaAlimento);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    IdVendedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.IdVendedor);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    IdEvento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    IdResponsavel = table.Column<int>(nullable: false),
                    Local = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_IdResponsavel",
                        column: x => x.IdResponsavel,
                        principalTable: "Responsavel",
                        principalColumn: "IdResponsavel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtesaoEvento",
                columns: table => new
                {
                    IdArtesaoEvento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdArtesao = table.Column<int>(nullable: false),
                    IdEvento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtesaoEvento", x => x.IdArtesaoEvento);
                    table.ForeignKey(
                        name: "FK_ArtesaoEvento_Artesao_IdArtesao",
                        column: x => x.IdArtesao,
                        principalTable: "Artesao",
                        principalColumn: "IdArtesao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtesaoEvento_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doacao",
                columns: table => new
                {
                    IdDoacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    IdDoador = table.Column<int>(nullable: false),
                    IdEvento = table.Column<int>(nullable: false),
                    Origem = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacao", x => x.IdDoacao);
                    table.ForeignKey(
                        name: "FK_Doacao_Doador_IdDoador",
                        column: x => x.IdDoador,
                        principalTable: "Doador",
                        principalColumn: "IdDoador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doacao_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventoCliente",
                columns: table => new
                {
                    IdEventoCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(nullable: false),
                    IdEvento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoCliente", x => x.IdEventoCliente);
                    table.ForeignKey(
                        name: "FK_EventoCliente_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventoCliente_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingresso",
                columns: table => new
                {
                    IdIngresso = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    IdEvento = table.Column<int>(nullable: false),
                    IdVendedor = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresso", x => x.IdIngresso);
                    table.ForeignKey(
                        name: "FK_Ingresso_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingresso_Vendedor_IdVendedor",
                        column: x => x.IdVendedor,
                        principalTable: "Vendedor",
                        principalColumn: "IdVendedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    IDMaterial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAquisicao = table.Column<DateTime>(nullable: false),
                    IdEvento = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.IDMaterial);
                    table.ForeignKey(
                        name: "FK_Material_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtesaoEvento_IdArtesao",
                table: "ArtesaoEvento",
                column: "IdArtesao");

            migrationBuilder.CreateIndex(
                name: "IX_ArtesaoEvento_IdEvento",
                table: "ArtesaoEvento",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Doacao_IdDoador",
                table: "Doacao",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_Doacao_IdEvento",
                table: "Doacao",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdResponsavel",
                table: "Evento",
                column: "IdResponsavel");

            migrationBuilder.CreateIndex(
                name: "IX_EventoCliente_IdCliente",
                table: "EventoCliente",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_EventoCliente_IdEvento",
                table: "EventoCliente",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresso_IdEvento",
                table: "Ingresso",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresso_IdVendedor",
                table: "Ingresso",
                column: "IdVendedor");

            migrationBuilder.CreateIndex(
                name: "IX_Material_IdEvento",
                table: "Material",
                column: "IdEvento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtesaoEvento");

            migrationBuilder.DropTable(
                name: "Beneficiado");

            migrationBuilder.DropTable(
                name: "Doacao");

            migrationBuilder.DropTable(
                name: "EventoCliente");

            migrationBuilder.DropTable(
                name: "Ingresso");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "ReceitaArtesao");

            migrationBuilder.DropTable(
                name: "VendaAlimento");

            migrationBuilder.DropTable(
                name: "Artesao");

            migrationBuilder.DropTable(
                name: "Doador");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Responsavel");
        }
    }
}

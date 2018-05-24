using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class initial : Migration
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                    Indicacao = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doador", x => x.IdDoador);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    IdDocumento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    DataInsercao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.IdDocumento);
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
                    IdMembro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AfastamentoSaida = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    BairroEmpresa = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    CepEmpresa = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    CidadeEmpresa = table.Column<string>(nullable: true),
                    CnpjCpf = table.Column<string>(nullable: true),
                    ComplementoEmpresa = table.Column<string>(nullable: true),
                    ComplementoEndereco = table.Column<string>(nullable: true),
                    DatNascEsposo = table.Column<DateTime>(nullable: false),
                    DatNascFilho1 = table.Column<string>(nullable: true),
                    DataCasamento = table.Column<DateTime>(nullable: false),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: false),
                    DocIdentidade = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailEmpresa = table.Column<string>(nullable: true),
                    Empresa = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    EnderecoEmpresa = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true),
                    FaxEmpresa = table.Column<string>(nullable: true),
                    InfoImportantes = table.Column<string>(nullable: true),
                    InscricaoEstadual = table.Column<string>(nullable: true),
                    LugarNascimento = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    NomeEsposo = table.Column<string>(nullable: true),
                    NomeFilho1 = table.Column<string>(nullable: true),
                    NumeroEmpresa = table.Column<string>(nullable: true),
                    NumeroEndereco = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    ProfissaoCargo = table.Column<string>(nullable: true),
                    ReturnUrl = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    TelefoneEmpresa = table.Column<string>(nullable: true),
                    TipoSanguineo = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: true),
                    UFEndereco = table.Column<string>(nullable: true),
                    UfEmpresa = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.IdMembro);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Caridade",
                columns: table => new
                {
                    IdCaridade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    IdBeneficiado = table.Column<int>(nullable: false),
                    IdItem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caridade", x => x.IdCaridade);
                    table.ForeignKey(
                        name: "FK_Caridade_Beneficiado_IdBeneficiado",
                        column: x => x.IdBeneficiado,
                        principalTable: "Beneficiado",
                        principalColumn: "IDBeneficiado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Caridade_Item_IdItem",
                        column: x => x.IdItem,
                        principalTable: "Item",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    IdEvento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubeAgendado = table.Column<bool>(nullable: false),
                    ConfirmarNumeroMesas = table.Column<bool>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Local = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    idResponsavelBebidas = table.Column<int>(nullable: false),
                    idResponsavelCaixas = table.Column<int>(nullable: false),
                    idResponsavelCozinha = table.Column<int>(nullable: false),
                    idResponsavelLimpeza = table.Column<int>(nullable: false),
                    idResponsavelLixo = table.Column<int>(nullable: false),
                    idResponsavelMesa = table.Column<int>(nullable: false),
                    idResponsavelPalco = table.Column<int>(nullable: false),
                    idResponsavelSeguranca = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_idResponsavelBebidas",
                        column: x => x.idResponsavelBebidas,
                        principalTable: "Responsavel",
                        principalColumn: "IdMembro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_idResponsavelCaixas",
                        column: x => x.idResponsavelCaixas,
                        principalTable: "Responsavel",
                        principalColumn: "IdMembro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_idResponsavelCozinha",
                        column: x => x.idResponsavelCozinha,
                        principalTable: "Responsavel",
                        principalColumn: "IdMembro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_idResponsavelLimpeza",
                        column: x => x.idResponsavelLimpeza,
                        principalTable: "Responsavel",
                        principalColumn: "IdMembro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_idResponsavelLixo",
                        column: x => x.idResponsavelLixo,
                        principalTable: "Responsavel",
                        principalColumn: "IdMembro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_idResponsavelMesa",
                        column: x => x.idResponsavelMesa,
                        principalTable: "Responsavel",
                        principalColumn: "IdMembro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_idResponsavelPalco",
                        column: x => x.idResponsavelPalco,
                        principalTable: "Responsavel",
                        principalColumn: "IdMembro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Responsavel_idResponsavelSeguranca",
                        column: x => x.idResponsavelSeguranca,
                        principalTable: "Responsavel",
                        principalColumn: "IdMembro",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArtesaoEvento_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistEvento",
                columns: table => new
                {
                    IDChecklist = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDEvento = table.Column<int>(nullable: false),
                    ReservaLocal = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistEvento", x => x.IDChecklist);
                    table.ForeignKey(
                        name: "FK_ChecklistEvento_Evento_IDEvento",
                        column: x => x.IDEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doacao_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventoCliente_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingresso_Vendedor_IdVendedor",
                        column: x => x.IdVendedor,
                        principalTable: "Vendedor",
                        principalColumn: "IdVendedor",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Caridade_IdBeneficiado",
                table: "Caridade",
                column: "IdBeneficiado");

            migrationBuilder.CreateIndex(
                name: "IX_Caridade_IdItem",
                table: "Caridade",
                column: "IdItem");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistEvento_IDEvento",
                table: "ChecklistEvento",
                column: "IDEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Doacao_IdDoador",
                table: "Doacao",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_Doacao_IdEvento",
                table: "Doacao",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_idResponsavelBebidas",
                table: "Evento",
                column: "idResponsavelBebidas");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_idResponsavelCaixas",
                table: "Evento",
                column: "idResponsavelCaixas");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_idResponsavelCozinha",
                table: "Evento",
                column: "idResponsavelCozinha");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_idResponsavelLimpeza",
                table: "Evento",
                column: "idResponsavelLimpeza");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_idResponsavelLixo",
                table: "Evento",
                column: "idResponsavelLixo");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_idResponsavelMesa",
                table: "Evento",
                column: "idResponsavelMesa");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_idResponsavelPalco",
                table: "Evento",
                column: "idResponsavelPalco");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_idResponsavelSeguranca",
                table: "Evento",
                column: "idResponsavelSeguranca");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Caridade");

            migrationBuilder.DropTable(
                name: "ChecklistEvento");

            migrationBuilder.DropTable(
                name: "Doacao");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "EventoCliente");

            migrationBuilder.DropTable(
                name: "Ingresso");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "ReceitaArtesao");

            migrationBuilder.DropTable(
                name: "VendaAlimento");

            migrationBuilder.DropTable(
                name: "Artesao");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Beneficiado");

            migrationBuilder.DropTable(
                name: "Item");

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

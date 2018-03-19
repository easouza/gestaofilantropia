using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class Ingresso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingresso",
                columns: table => new
                {
                    IdIngresso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataVenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEvento = table.Column<int>(type: "int", nullable: false),
                    IdVendedor = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Ingresso_IdEvento",
                table: "Ingresso",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresso_IdVendedor",
                table: "Ingresso",
                column: "IdVendedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingresso");
        }
    }
}

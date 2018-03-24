using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class Caridade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Caridade_Item_IdItem",
                        column: x => x.IdItem,
                        principalTable: "Item",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caridade_IdBeneficiado",
                table: "Caridade",
                column: "IdBeneficiado");

            migrationBuilder.CreateIndex(
                name: "IX_Caridade_IdItem",
                table: "Caridade",
                column: "IdItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caridade");
        }
    }
}

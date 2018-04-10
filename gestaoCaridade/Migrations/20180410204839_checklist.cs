using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class checklist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistEvento_IDEvento",
                table: "ChecklistEvento",
                column: "IDEvento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChecklistEvento");
        }
    }
}

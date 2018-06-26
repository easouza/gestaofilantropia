using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ComissaoArtesao",
                table: "ArtesaoEvento",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ValorVendido",
                table: "ArtesaoEvento",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComissaoArtesao",
                table: "ArtesaoEvento");

            migrationBuilder.DropColumn(
                name: "ValorVendido",
                table: "ArtesaoEvento");
        }
    }
}

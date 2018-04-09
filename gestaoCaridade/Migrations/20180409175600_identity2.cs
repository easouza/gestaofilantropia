using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class identity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Responsavel",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Responsavel");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class identity3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReturnUrl",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Responsavel",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnUrl",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Responsavel");
        }
    }
}

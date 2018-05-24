using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class checklist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Ingresso",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Doacao",
                newName: "Objeto");

            migrationBuilder.AddColumn<bool>(
                name: "CarimbarCartela",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ComparPlasticoEmbalar",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ComprarCartela",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ConfeccionarConvites",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmarFuncionarios",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ContratarSegurancas",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ContratarSom",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EntregarConvites",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FazerAgradecimento",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FazerCardapio",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FazerCartaAgradecimento",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FazerCartaBetheisDemolays",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FazerCartaPedidos",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FazerEscala",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FazerListaBrindes",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FazerValeTicket",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LevarTroco",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MarcarHorarioChegada",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NumerarCartela",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarBandejas",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarBebidas",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarBloquinho",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarBuchinha",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarCaixaDinheiro",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarCestaBebida",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarComidas",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarCoposColheres",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarCrachas",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarFosforo",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarGuardanapos",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarLapis",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarPanodePrato",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarPapelHigienico",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarPerfex",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarPratinhos",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarPratosGarfos",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarRoleta",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarSacoLixo",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarToalhaMesa",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvidenciarVasilha",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SepararFichas",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VerificaCozinha",
                table: "Evento",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarimbarCartela",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ComparPlasticoEmbalar",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ComprarCartela",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ConfeccionarConvites",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ConfirmarFuncionarios",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ContratarSegurancas",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ContratarSom",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "EntregarConvites",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FazerAgradecimento",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FazerCardapio",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FazerCartaAgradecimento",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FazerCartaBetheisDemolays",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FazerCartaPedidos",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FazerEscala",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FazerListaBrindes",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FazerValeTicket",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "LevarTroco",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "MarcarHorarioChegada",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "NumerarCartela",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarBandejas",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarBebidas",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarBloquinho",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarBuchinha",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarCaixaDinheiro",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarCestaBebida",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarComidas",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarCoposColheres",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarCrachas",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarFosforo",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarGuardanapos",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarLapis",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarPanodePrato",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarPapelHigienico",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarPerfex",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarPratinhos",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarPratosGarfos",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarRoleta",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarSacoLixo",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarToalhaMesa",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ProvidenciarVasilha",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "SepararFichas",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "VerificaCozinha",
                table: "Evento");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Ingresso",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "Objeto",
                table: "Doacao",
                newName: "Tipo");
        }
    }
}

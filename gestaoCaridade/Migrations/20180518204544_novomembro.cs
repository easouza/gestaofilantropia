using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gestaoCaridade.Migrations
{
    public partial class novomembro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "Responsavel",
                newName: "UfEmpresa");

            migrationBuilder.AddColumn<string>(
                name: "AfastamentoSaida",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BairroEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CepEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CidadeEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CnpjCpf",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComplementoEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComplementoEndereco",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatNascEsposo",
                table: "Responsavel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DatNascFilho1",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataCasamento",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataSaida",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocIdentidade",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaxEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InfoImportantes",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InscricaoEstadual",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LugarNascimento",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeEsposo",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeFilho1",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroEndereco",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfissaoCargo",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefoneEmpresa",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoSanguineo",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UFEndereco",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ClubeAgendado",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmarNumeroMesas",
                table: "Evento",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AfastamentoSaida",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "BairroEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "CepEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "CidadeEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "CnpjCpf",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "ComplementoEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "ComplementoEndereco",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "DatNascEsposo",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "DatNascFilho1",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "DataCasamento",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "DataSaida",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "DocIdentidade",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "EmailEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "EnderecoEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "FaxEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "InfoImportantes",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "InscricaoEstadual",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "LugarNascimento",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "NomeEsposo",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "NomeFilho1",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "NumeroEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "NumeroEndereco",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "ProfissaoCargo",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "TelefoneEmpresa",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "TipoSanguineo",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "UFEndereco",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "ClubeAgendado",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ConfirmarNumeroMesas",
                table: "Evento");

            migrationBuilder.RenameColumn(
                name: "UfEmpresa",
                table: "Responsavel",
                newName: "Cargo");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace ProgramaPtcc.Migrations
{
    public partial class criaTudo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    IdMat = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.IdMat);
                });
            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    CodTurma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Horario = table.Column<string>(nullable: true),
                    NumAlunos = table.Column<int>(nullable: false),
                    Sala = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.CodTurma);
                });
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<int>(nullable: false),
                    CarteiraTrab = table.Column<string>(nullable: true),
                    DataNasc = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Enderaco = table.Column<string>(nullable: true),
                    FaixaComiss = table.Column<double>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Profissao = table.Column<string>(nullable: true),
                    RG = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<int>(nullable: false),
                    CarteiraTrab = table.Column<string>(nullable: true),
                    DataNasc = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Enderaco = table.Column<string>(nullable: true),
                    FaixaComiss = table.Column<double>(nullable: false),
                    IdMat = table.Column<int>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    RG = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professor_Materia_IdMat",
                        column: x => x.IdMat,
                        principalTable: "Materia",
                        principalColumn: "IdMat",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    NumMat = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodTurma = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    NomeResp = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.NumMat);
                    table.ForeignKey(
                        name: "FK_Aluno_Turma_CodTurma",
                        column: x => x.CodTurma,
                        principalTable: "Turma",
                        principalColumn: "CodTurma",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Boletim",
                columns: table => new
                {
                    IdBol = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bimestre = table.Column<double>(nullable: false),
                    Frequencia = table.Column<double>(nullable: false),
                    IdMat = table.Column<int>(nullable: false),
                    Nota = table.Column<double>(nullable: false),
                    NumMat = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletim", x => x.IdBol);
                    table.ForeignKey(
                        name: "FK_Boletim_Materia_IdMat",
                        column: x => x.IdMat,
                        principalTable: "Materia",
                        principalColumn: "IdMat",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boletim_Aluno_NumMat",
                        column: x => x.NumMat,
                        principalTable: "Aluno",
                        principalColumn: "NumMat",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Boletim");
            migrationBuilder.DropTable("Professor");
            migrationBuilder.DropTable("Funcionario");
            migrationBuilder.DropTable("Aluno");
            migrationBuilder.DropTable("Materia");
            migrationBuilder.DropTable("Turma");
        }
    }
}

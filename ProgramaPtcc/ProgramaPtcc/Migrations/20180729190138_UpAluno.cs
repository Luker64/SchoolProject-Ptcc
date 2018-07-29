using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace ProgramaPtcc.Migrations
{
    public partial class UpAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Aluno_Turma_CodTurma", table: "Aluno");
            migrationBuilder.DropForeignKey(name: "FK_Boletim_Materia_IdMat", table: "Boletim");
            migrationBuilder.DropForeignKey(name: "FK_Boletim_Aluno_NumMat", table: "Boletim");
            migrationBuilder.DropForeignKey(name: "FK_Professor_Materia_IdMat", table: "Professor");
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Aluno",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_CodTurma",
                table: "Aluno",
                column: "CodTurma",
                principalTable: "Turma",
                principalColumn: "CodTurma",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Boletim_Materia_IdMat",
                table: "Boletim",
                column: "IdMat",
                principalTable: "Materia",
                principalColumn: "IdMat",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Boletim_Aluno_NumMat",
                table: "Boletim",
                column: "NumMat",
                principalTable: "Aluno",
                principalColumn: "NumMat",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Professor_Materia_IdMat",
                table: "Professor",
                column: "IdMat",
                principalTable: "Materia",
                principalColumn: "IdMat",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Aluno_Turma_CodTurma", table: "Aluno");
            migrationBuilder.DropForeignKey(name: "FK_Boletim_Materia_IdMat", table: "Boletim");
            migrationBuilder.DropForeignKey(name: "FK_Boletim_Aluno_NumMat", table: "Boletim");
            migrationBuilder.DropForeignKey(name: "FK_Professor_Materia_IdMat", table: "Professor");
            migrationBuilder.DropColumn(name: "Senha", table: "Aluno");
            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_CodTurma",
                table: "Aluno",
                column: "CodTurma",
                principalTable: "Turma",
                principalColumn: "CodTurma",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Boletim_Materia_IdMat",
                table: "Boletim",
                column: "IdMat",
                principalTable: "Materia",
                principalColumn: "IdMat",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Boletim_Aluno_NumMat",
                table: "Boletim",
                column: "NumMat",
                principalTable: "Aluno",
                principalColumn: "NumMat",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Professor_Materia_IdMat",
                table: "Professor",
                column: "IdMat",
                principalTable: "Materia",
                principalColumn: "IdMat",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

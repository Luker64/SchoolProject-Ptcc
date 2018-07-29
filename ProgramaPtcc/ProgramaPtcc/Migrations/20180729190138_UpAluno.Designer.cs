using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ProgramaPtcc.Entidades;

namespace ProgramaPtcc.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20180729190138_UpAluno")]
    partial class UpAluno
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProgramaPtcc.Aluno", b =>
                {
                    b.Property<int>("NumMat")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodTurma");

                    b.Property<string>("Email");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeResp");

                    b.Property<string>("Senha");

                    b.Property<int>("Telefone");

                    b.HasKey("NumMat");
                });

            modelBuilder.Entity("ProgramaPtcc.Entidades.Boletim", b =>
                {
                    b.Property<int>("IdBol")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Bimestre");

                    b.Property<double>("Frequencia");

                    b.Property<int>("IdMat");

                    b.Property<double>("Nota");

                    b.Property<int>("NumMat");

                    b.HasKey("IdBol");
                });

            modelBuilder.Entity("ProgramaPtcc.Entidades.Materia", b =>
                {
                    b.Property<int>("IdMat")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("IdMat");
                });

            modelBuilder.Entity("ProgramaPtcc.Entidades.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CPF");

                    b.Property<string>("CarteiraTrab");

                    b.Property<string>("DataNasc");

                    b.Property<string>("Email");

                    b.Property<string>("Enderaco");

                    b.Property<double>("FaixaComiss");

                    b.Property<int>("IdMat");

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("RG");

                    b.Property<string>("Senha");

                    b.Property<int>("Telefone");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("ProgramaPtcc.Entidades.Turma", b =>
                {
                    b.Property<int>("CodTurma")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Horario");

                    b.Property<int>("NumAlunos");

                    b.Property<string>("Sala");

                    b.HasKey("CodTurma");
                });

            modelBuilder.Entity("ProgramaPtcc.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CPF");

                    b.Property<string>("CarteiraTrab");

                    b.Property<string>("DataNasc");

                    b.Property<string>("Email");

                    b.Property<string>("Enderaco");

                    b.Property<double>("FaixaComiss");

                    b.Property<string>("Nome");

                    b.Property<string>("Profissao");

                    b.Property<string>("RG");

                    b.Property<int>("Telefone");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("ProgramaPtcc.Aluno", b =>
                {
                    b.HasOne("ProgramaPtcc.Entidades.Turma")
                        .WithMany()
                        .HasForeignKey("CodTurma");
                });

            modelBuilder.Entity("ProgramaPtcc.Entidades.Boletim", b =>
                {
                    b.HasOne("ProgramaPtcc.Entidades.Materia")
                        .WithMany()
                        .HasForeignKey("IdMat");

                    b.HasOne("ProgramaPtcc.Aluno")
                        .WithMany()
                        .HasForeignKey("NumMat");
                });

            modelBuilder.Entity("ProgramaPtcc.Entidades.Professor", b =>
                {
                    b.HasOne("ProgramaPtcc.Entidades.Materia")
                        .WithMany()
                        .HasForeignKey("IdMat");
                });
        }
    }
}

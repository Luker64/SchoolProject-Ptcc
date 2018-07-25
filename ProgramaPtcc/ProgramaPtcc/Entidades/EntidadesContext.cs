using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace ProgramaPtcc.Entidades
{
    class EntidadesContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Boletim> Boletins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["EscolaDBCS"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConnection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}

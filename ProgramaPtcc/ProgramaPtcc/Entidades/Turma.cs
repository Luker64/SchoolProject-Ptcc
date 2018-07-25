using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPtcc.Entidades
{
    class Turma
    {
        [Key]
        public int CodTurma { get; set; }
        public string Sala { get; set; }
        public int NumAlunos { get; set; }
        public virtual IList<Aluno> Alunos { get; set; }
        public string Horario { get; set; }
    }
}

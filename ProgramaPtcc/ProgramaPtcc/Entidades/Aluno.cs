using ProgramaPtcc.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPtcc
{
    class Aluno
    {
        [Key]
        public int NumMat { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int CodTurma { get; set; }
        public virtual Turma Turma { get; set; }
        public string NomeResp { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Senha { get; set; }
    }
}

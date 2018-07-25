using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPtcc.Entidades
{
    class Boletim
    {
        [Key]
        public int IdBol { get; set; }
        public int NumMat { get; set; }
        public virtual Aluno Aluno { get; set; }
        public int IdMat { get; set; }
        public virtual Materia Materia { get; set; }
        public double Bimestre { get; set; }
        public double Nota { get; set; }
        public double Frequencia { get; set; }
    }
}

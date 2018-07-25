using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPtcc.Entidades
{
    class Professor : Empregado
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdMat { get; set; }
        public virtual Materia Materia { get; set; }
    }
}

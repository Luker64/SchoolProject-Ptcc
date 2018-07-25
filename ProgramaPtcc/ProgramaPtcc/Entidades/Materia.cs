using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPtcc.Entidades
{
    class Materia
    {
        [Key]
        public int IdMat { get; set; }
        public string Nome { get; set; }
    }
}

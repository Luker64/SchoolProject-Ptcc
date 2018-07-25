using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPtcc
{
    abstract class Empregado
    {
        [Key]
        public int Id { get; set; }
        public int CPF { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }        
        public string Email { get; set; }
        public string Enderaco { get; set; }
        public string DataNasc { get; set; }
        public int Telefone { get; set; }
        public string CarteiraTrab { get; set; }
        public double FaixaComiss { get; set; }
    }
}

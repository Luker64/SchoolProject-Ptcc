using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPtcc.Entidades
{
    class AlunoDAO
    {
        private EntidadesContext context;

        public AlunoDAO() { context = new EntidadesContext(); }

        public void Add(Aluno a)
        {
            try
            {
                context.Alunos.Add(a);
                context.SaveChanges();
            }
            catch { MessageBox.Show("Ocorreu algum erro, tente novamente"); }
            
        }
        public void Alt()
        {
            try
            {
                context.SaveChanges();
            }            
            catch { MessageBox.Show("Ocorreu algum erro, tente novamente"); }
        }
        public IList<Aluno> BuscaId(int Id)
        {
            try
            {
                EntidadesContext cont = new EntidadesContext();

                var busca = from a in cont.Alunos where a.NumMat == Id select a;
                return busca.ToList();
            }
            catch { MessageBox.Show("Ocorreu algum erro, tente novamente"); return null; }
        }

        public Aluno BuscaPorId(int Id)
        {
            try
            {

                EntidadesContext cont = new EntidadesContext();

                var busca = context.Alunos.FirstOrDefault(a => a.NumMat == Id);
                return busca;
            }
            catch { MessageBox.Show("Ocorreu algum erro, tente novamente"); return null; }
        }
    }
}

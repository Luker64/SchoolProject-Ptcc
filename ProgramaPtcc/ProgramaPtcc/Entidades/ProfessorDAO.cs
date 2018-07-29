using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPtcc.Entidades
{
    class ProfessorDAO
    {
        private EntidadesContext context;

        public ProfessorDAO() { context = new EntidadesContext(); }

        public void Add(Professor p)
        {
            try
            {
                context.Professores.Add(p);
                context.SaveChanges();
            }
            catch { MessageBox.Show("Ocorreu algum erro, tente novamente"); }
        }

        public bool Login(string log, string pass)
        {
            try
            {
                Professor pro = context.Professores.FirstOrDefault(p => p.Login == log);
                if (pro.Senha == pass)
                {
                    if(pro.Id == 1)
                    {
                        Global.Permissao = 1;
                    }
                    if (pro.Id != 1)
                    {
                        Global.Permissao = 2;
                    }
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
        public void Alt()
        {
            try
            {
                context.SaveChanges();
            }
            catch { MessageBox.Show("Ocorreu algum erro, tente novamente"); }
        }
        public IList<Professor> BuscaId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = from p in cont.Professores where p.Id == Id select p;
            return busca.ToList();
        }

        public Professor BuscaPorId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = context.Professores.FirstOrDefault(p => p.Id == Id);
            return busca;
        }
    }
}

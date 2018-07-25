using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPtcc.Entidades
{
    class FuncionarioDAO
    {
        private EntidadesContext context;

        public FuncionarioDAO() { context = new EntidadesContext(); }

        public void Add(Funcionario f)
        {
            try
            {
                context.Funcionarios.Add(f);
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
        public IList<Funcionario> BuscaId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = from f in cont.Funcionarios where f.Id == Id select f;
            return busca.ToList();
        }

        public Funcionario BuscaPorId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = context.Funcionarios.FirstOrDefault(f => f.Id == Id);
            return busca;
        }
    }
}

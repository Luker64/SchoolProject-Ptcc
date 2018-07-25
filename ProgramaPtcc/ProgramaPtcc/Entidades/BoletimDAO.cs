using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPtcc.Entidades
{
    class BoletimDAO
    {
        private EntidadesContext context;

        public BoletimDAO() { context = new EntidadesContext(); }

        public void Add(Boletim b)
        {
            try
            {
                context.Boletins.Add(b);
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
        public IList<Boletim> BuscaId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = from b in cont.Boletins where b.IdBol == Id select b;
            return busca.ToList();
        }

        public Boletim BuscaPorId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = context.Boletins.FirstOrDefault(b => b.IdBol == Id);
            return busca;
        }

        public IList<Boletim> BuscarAluno(int Id)
        {
            EntidadesContext cont = new EntidadesContext();
            var busca = from b in cont.Boletins where b.NumMat == Id select b;
            return busca.ToList();
        }            
    }
}

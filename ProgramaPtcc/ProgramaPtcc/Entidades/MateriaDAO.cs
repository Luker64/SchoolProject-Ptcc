using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPtcc.Entidades
{
    class MateriaDAO
    {
        private EntidadesContext context;

        public MateriaDAO() { context = new EntidadesContext(); }

        public void Add(Materia m)
        {
            try
            {
                context.Materias.Add(m);
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
        public IList<Materia> BuscaId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = from m in cont.Materias where m.IdMat== Id select m;
            return busca.ToList();
        }

        public Materia BuscaPorId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = context.Materias.FirstOrDefault(m => m.IdMat == Id);
            return busca;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ProgramaPtcc.Entidades
{
    class TurmaDAO
    {
        private EntidadesContext context;

        public TurmaDAO() { context = new EntidadesContext(); }

        public void Add(Turma t)
        {
            try
            {
                //CriaExcel(t.Horario);
                context.Turmas.Add(t);
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
        public IList<Turma> BuscaId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = from t in cont.Turmas where t.CodTurma == Id select t;
            return busca.ToList();
        }

        public Turma BuscaPorId(int Id)
        {
            EntidadesContext cont = new EntidadesContext();

            var busca = context.Turmas.FirstOrDefault(t => t.CodTurma == Id);
            return busca;
        }

        private void CriaExcel(string hor)
        {
            _Application oApp = new Microsoft.Office.Interop.Excel.Application();
            oApp.Visible = false;

            Workbook oWorkbook = oApp.Workbooks.Add("F:\\ETEC\\3 ANO\\PTCC\\ProgramaPtcc2107\\ProgramaPtcc (1)\\ProgramaPtcc\\Horarios\\" + hor);
            oWorkbook.Close();
            oApp.Quit();
        }
    }
}

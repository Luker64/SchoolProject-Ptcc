using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ProgramaPtcc
{
    public partial class UserHorario : UserControl
    {
        public UserHorario()
        {
            InitializeComponent();
        }

        private void UserHorario_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                _Application oApp = new Microsoft.Office.Interop.Excel.Application();
                oApp.Visible = false;

                string text = txt_filtro.Text;
                Workbook oWorkbook = oApp.Workbooks.Open("F:\\ETEC\\3 ANO\\PTCC\\ProgramaPtcc\\Horarios\\" + text);
                 Worksheet sheet = (Worksheet)oWorkbook.Worksheets[1];

                GetValues(sheet);

                oWorkbook.Close();
                oApp.Quit();
            }
            catch
            {
                MessageBox.Show("Erro ao encontrar este Horario");
            }

        }


        public void GetValues(Worksheet sheet)
        {
            string[,] aulas = new string[10, 10];
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    try
                    {
                        aulas[i, j] = (string)(sheet.Cells[i, j] as Range).Value;

                    }
                    catch { }

                }
            }
            Put(aulas);
        }

        public void Put(string[,] aulas)
        {
            lbl_11.Text = aulas[0, 0];
            lbl_21.Text = aulas[1, 0];
            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Label)
                {
                    if (!(c.Name.Contains("not")))
                    {
                        c.Visible = true;
                        int n1 = int.Parse(c.Name.Substring(c.Name.Length - 1, 1));
                        int n2 = int.Parse(c.Name.Substring(c.Name.Length - 2, 1));
                        c.Text = aulas[n2, n1];
                    }
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

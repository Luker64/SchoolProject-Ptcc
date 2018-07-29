using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPtcc.Entidades
{
    public partial class UserBoletim : UserControl
    {
        public UserBoletim()
        {
            InitializeComponent();
        }

        private void btncons_Click(object sender, EventArgs e)
        {
            try
            {                
                int Id = int.Parse(txtid.Text);
                if (!(Global.Permissao == 3 && Global.AlunoId != Id))
                {
                    BoletimDAO dao = new BoletimDAO();
                    IList<Boletim> bols = dao.BuscarAluno(Id);
                    var bindingList = new BindingList<Boletim>(bols);
                    var source = new BindingSource(bindingList, null);
                    dgv.DataSource = source;
                    dgv.Columns["IdBol"].HeaderText = "Id do Boletim";
                    dgv.Columns["IdMat"].HeaderText = "Id da Materia";
                    dgv.Columns["NumMat"].HeaderText = "Numero da Matricula";
                    dgv.Columns["Aluno"].Visible = false; dgv.Columns["Materia"].Visible = false;
                }
                else { MessageBox.Show("Você só pode pesquisar o seu Boletim!"); }
                    
            }
            catch { MessageBox.Show("Ocorreu Um erro"); }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

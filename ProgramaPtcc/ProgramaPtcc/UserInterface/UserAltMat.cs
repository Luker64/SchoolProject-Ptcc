using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaPtcc.Entidades;

namespace ProgramaPtcc
{
    public partial class UserAltMat : UserControl
    {
        MateriaDAO dao = new MateriaDAO();
        public UserAltMat()
        {
            InitializeComponent();
        }

        private void btn_limpmat_Click(object sender, EventArgs e)
        {
            txtNomemat.Clear();
        }

        private void btn_voltmat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_altmat_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtid.Text);
                Materia m = dao.BuscaPorId(Id);
                m.Nome = txtNomemat.Text;
                dao.Alt();
                btn_limpmat_Click(sender, e);
            }
            catch { MessageBox.Show("Ocorreu algum erro, tente novamente"); }

}

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtid.Text);
                Materia m = dao.BuscaPorId(Id);
                txtNomemat.Text = m.Nome;
                txtNomemat.Enabled = true;
                btn_altmat.Enabled = true;
                btn_limpmat.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Não Existe com este Id");
            }
        }
    }
}

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

namespace ProgramaPtcc {
    public partial class UserCadMat : UserControl {
        public UserCadMat()
        {
            InitializeComponent();
        }

        private void lblNomemat_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpmat_Click(object sender, EventArgs e)
        {
           txtNomemat.Clear();
        }

        private void btn_voltmat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_cadmat_Click(object sender, EventArgs e)
        {
            Materia m = new Materia();
            m.Nome = txtNomemat.Text;
            MateriaDAO mdao = new MateriaDAO();
            mdao.Add(m);
            btn_limpmat_Click(sender, e);
        }
    }
}

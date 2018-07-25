using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPtcc {
    public partial class UserMat : UserControl {
        public UserMat()
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
    }
}

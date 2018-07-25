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
    public partial class UserTur : UserControl {
        public UserTur()
        {
            InitializeComponent();
        }

        private void lblNalunos_Click(object sender, EventArgs e)
        {

        }

        private void btn_limptur_Click(object sender, EventArgs e)
        {
            txtHor.Clear();
            txtNalun.Clear();
            txtSal.Clear();
        }

        private void btn_volttur_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

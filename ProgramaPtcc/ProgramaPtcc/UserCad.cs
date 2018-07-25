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
    public partial class UserCadAlu : UserControl {
        public UserCadAlu()
        {
            InitializeComponent();
        }

        private void btn_limpal_Click(object sender, EventArgs e)
        {
            txtb_turma.Clear();
            txtb_tel.Clear();
            txtb_nummat.Clear();
            txtb_nomeresp.Clear();
            txtb_nome.Clear();
            txtb_id.Clear();
            txtb_email.Clear();
        }

        private void btn_voltal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

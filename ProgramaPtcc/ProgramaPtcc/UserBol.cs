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
    public partial class UserBol : UserControl {
        public UserBol()
        {
            InitializeComponent();
        }

        private void UserBol_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpbol_Click(object sender, EventArgs e)
        {
            txtCodmat.Clear();
            txtNummat.Clear();
            txtNota.Clear();
            txtFreq.Clear();
        }

        private void btn_voltbol_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

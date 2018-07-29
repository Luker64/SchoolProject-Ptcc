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
    public partial class UserCadBol : UserControl {
        public UserCadBol()
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
            txtBim.Clear();
        }

        private void btn_voltbol_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_cadbol_Click(object sender, EventArgs e)
        {
            Boletim b = new Boletim();
            b.NumMat = int.Parse(txtNummat.Text);
            b.IdMat = int.Parse(txtCodmat.Text);
            b.Bimestre = double.Parse(txtBim.Text);
            b.Nota = double.Parse(txtNota.Text);
            b.Frequencia = double.Parse(txtFreq.Text);

            BoletimDAO bdao = new BoletimDAO();
            bdao.Add(b);
        }
    }
}

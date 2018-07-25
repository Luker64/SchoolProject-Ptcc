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
    public partial class UserCadTur : UserControl {
        public UserCadTur()
        {
            InitializeComponent();
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

        private void btn_cadtur_Click(object sender, EventArgs e)
        {
            Turma t = new Turma();
            t.Sala = txtSal.Text;
            t.NumAlunos = int.Parse(txtNalun.Text);
            t.Horario = txtHor.Text;
            TurmaDAO tdao = new TurmaDAO();
            tdao.Add(t);
            btn_limptur_Click(sender, e);
        }

        private void UserCadTur_Load(object sender, EventArgs e)
        {

        }
    }
}

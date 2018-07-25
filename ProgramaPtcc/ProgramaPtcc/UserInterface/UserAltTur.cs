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
    public partial class UserAltTur : UserControl
    {
        TurmaDAO dao = new TurmaDAO();
        public UserAltTur()
        {
            InitializeComponent();
        }

        private void btn_limptur_Click(object sender, EventArgs e)
        {
            txtSal.Clear();
            txtNalun.Clear();
            txtHor.Clear();
        }

        private void btn_volttur_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_alttur_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtid.Text);
            Turma t = dao.BuscaPorId(Id);
            t.Sala = txtSal.Text;
            t.NumAlunos = int.Parse(txtNalun.Text);
            t.Horario = txtHor.Text;
            dao.Alt();
            btn_limptur_Click(sender, e);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtid.Text);
                Turma t = dao.BuscaPorId(Id);
                txtHor.Text = t.Horario;
                txtSal.Text = t.Sala;
                txtNalun.Text = t.NumAlunos.ToString();
                txtSal.Enabled = true;
                txtNalun.Enabled = true;
                txtHor.Enabled = true;
                btn_alttur.Enabled = true;
                btn_limptur.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Não Existe com este Id");
            }
        }
    }
}

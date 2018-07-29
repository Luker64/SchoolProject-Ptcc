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
    public partial class UserAltBol : UserControl
    {
        BoletimDAO dao = new BoletimDAO();
        public UserAltBol()
        {
            InitializeComponent();
        }

        private void btn_limpbol_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtCodmat.Clear();
            txtFreq.Clear();
            txtNota.Clear();
            txtNummat.Clear();
        }

        private void btn_voltbol_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_altbol_Click(object sender, EventArgs e)
        {
            try { 
            int Id = int.Parse(txtid.Text);
            Boletim b = dao.BuscaPorId(Id);
            b.NumMat = int.Parse(txtNummat.Text);
            b.Frequencia = double.Parse(txtFreq.Text);
            b.IdMat = int.Parse(txtCodmat.Text);
            b.Nota = double.Parse(txtNota.Text);
            dao.Alt();
            btn_limpbol_Click(sender, e);
            }
            catch { MessageBox.Show("Ocorreu algum erro, tente novamente"); }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Boletim b = new Boletim();
                int Id = int.Parse(txtid.Text);
                b = dao.BuscaPorId(Id);
                txtCodmat.Text = b.IdMat.ToString();
                txtFreq.Text = b.Frequencia.ToString();
                txtNota.Text = b.Nota.ToString();
                txtNummat.Text = b.NumMat.ToString();
                txtCodmat.Enabled = true;
                txtFreq.Enabled = true;
                txtNota.Enabled = true;
                txtNummat.Enabled = true;
                btn_altbol.Enabled = true;
                btn_limpbol.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Não Existe com este Id");
            }
        }
    }
}

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
    public partial class UserCadAlu : UserControl {
        public UserCadAlu()
        {
            InitializeComponent();
        }

        private void btn_limpal_Click(object sender, EventArgs e)
        {
            txtturma.Clear();
            txttel.Clear();
            txtnomeresp.Clear();
            txtnome.Clear();
            txtid.Clear();
            txtemail.Clear();
        }

        private void btn_voltal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_cadal_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            a.Nome = txtnome.Text;
            a.Idade = int.Parse(txtid.Text);
            a.CodTurma = int.Parse(txtturma.Text);
            a.NomeResp = txtnomeresp.Text;
            a.Email = txtemail.Text;
            a.Telefone = int.Parse(txttel.Text);
            AlunoDAO adao = new AlunoDAO();
            adao.Add(a);
            btn_limpal_Click(sender, e);
        }
    }
}

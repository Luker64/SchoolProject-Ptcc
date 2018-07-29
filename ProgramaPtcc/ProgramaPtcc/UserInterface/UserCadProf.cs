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
    public partial class UserCadProf : UserControl
    {
        public UserCadProf()
        {
            InitializeComponent();
        }

       

        private void btn_limpfn_Click(object sender, EventArgs e)
        {
            txtTel.Clear();
            txtRG.Clear();
            txtNome.Clear();
            txtNasc.Clear();
            txtFaixa.Clear();
            txtEnd.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtCdT.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtIdMat.Clear();
        }

        private void btn_voltprof_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_cadprof_Click(object sender, EventArgs e)
        {
            Professor p = new Professor();
            p.CPF = int.Parse(txtCPF.Text);
            p.Nome = txtNome.Text;
            p.RG = txtRG.Text;
            p.Email = txtEmail.Text;
            p.Enderaco = txtEnd.Text;
            p.DataNasc = txtNasc.Text;
            p.Telefone = int.Parse(txtTel.Text);
            p.CarteiraTrab = txtCdT.Text;
            p.FaixaComiss = double.Parse(txtFaixa.Text);
            p.IdMat = int.Parse(txtIdMat.Text);
            p.Login = txtLogin.Text;
            p.Senha = txtSenha.Text;

            ProfessorDAO pdao = new ProfessorDAO();
            pdao.Add(p);
            btn_limpfn_Click(sender, e);
        }

      
    }
}

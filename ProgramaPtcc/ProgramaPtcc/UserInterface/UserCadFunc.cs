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
    public partial class UserCadFunc : UserControl
    {
        public UserCadFunc()
        {
            InitializeComponent();
        }

       
        private void btn_voltfn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_limpfn_Click(object sender, EventArgs e)
        {
            txtTel.Clear();
            txtRG.Clear();
            txtProf.Clear();
            txtNome.Clear();
            txtNasc.Clear();
            txtFaixa.Clear();
            txtEnd.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtCdT.Clear();
        }

        private void btn_cadafn_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.CPF = int.Parse(txtCPF.Text);
            f.Nome = txtNome.Text;
            f.RG = txtRG.Text;
            f.Email = txtEmail.Text;
            f.Enderaco = txtEnd.Text;
            f.DataNasc = txtNasc.Text;
            f.Telefone = int.Parse(txtTel.Text);
            f.CarteiraTrab = txtCdT.Text;
            f.FaixaComiss = double.Parse(txtFaixa.Text);
            f.Profissao = txtProf.Text;

            FuncionarioDAO fdao = new FuncionarioDAO();
            fdao.Add(f);
            btn_limpfn_Click(sender, e);
        }

        
    }
}

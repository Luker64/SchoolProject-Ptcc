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
    public partial class UserAltFunc : UserControl
    {
        FuncionarioDAO dao = new FuncionarioDAO();
        public UserAltFunc()
        {
            InitializeComponent();
        }

        private void btn_limpfn_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txt_CdT.Clear();
            txt_CPF.Clear();
            txt_Email.Clear();
            txt_End.Clear();
            txt_Faixa.Clear();
            txt_Nasc.Clear();
            txt_Nome.Clear();
            txt_Prof.Clear();
            txt_RG.Clear();
            txt_Tel.Clear();
          
        }

        private void btn_voltfn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_altfn_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtid.Text);
            Funcionario f = dao.BuscaPorId(Id);
            f.CarteiraTrab=txt_CdT.Text;
            f.CPF=int.Parse(txt_CPF.Text);
            f.Email=txt_Email.Text;
            f.Enderaco=txt_End.Text;
            f.FaixaComiss=int.Parse(txt_Faixa.Text);
            f.DataNasc=txt_Nasc.Text;
            f.Nome=txt_Nome.Text;
            f.Profissao=txt_Prof.Text;
            f.RG=txt_RG.Text;
            f.Telefone=int.Parse(txt_Tel.Text);
            dao.Alt();
            btn_limpfn_Click(sender, e);
        }

        private void UserAltFunc_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtid.Text);
                Funcionario f = dao.BuscaPorId(Id);
                txt_CdT.Text = f.CarteiraTrab;
                txt_CPF.Text = f.CPF.ToString();
                txt_Email.Text = f.Email;
                txt_End.Text = f.Enderaco;
                txt_Faixa.Text = f.FaixaComiss.ToString();
                txt_Nasc.Text = f.DataNasc;
                txt_Nome.Text = f.Nome;
                txt_Prof.Text = f.Profissao;
                txt_RG.Text = f.RG.ToString();
                txt_Tel.Text = f.Telefone.ToString();
                txt_CdT.Enabled = true;
                txt_CPF.Enabled = true;
                txt_Email.Enabled = true;
                txt_End.Enabled = true;
                txt_Faixa.Enabled = true;
                txt_Nasc.Enabled = true;
                txt_Nome.Enabled = true;
                txt_Prof.Enabled = true;
                txt_RG.Enabled = true;
                txt_Tel.Enabled = true;
                btn_altfn.Enabled = true;
                btn_limpfn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Não Existe com este Id");
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}

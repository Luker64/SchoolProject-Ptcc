using System;
using System.Windows.Forms;
using ProgramaPtcc.Entidades;

namespace ProgramaPtcc
{
    public partial class UserAltProf : UserControl
    {
        ProfessorDAO dao = new ProfessorDAO();
        public UserAltProf()
        {
            InitializeComponent();
        }

        private void btn_limpprof_Click(object sender, EventArgs e)
        {
            txt_CdT.Clear();
            txt_CPF.Clear();
            txt_Email.Clear();
            txt_End.Clear();
            txt_Faixa.Clear();
            txt_Nasc.Clear();
            txt_Nome.Clear();
            txt_RG.Clear();
            txt_Tel.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtIdMat.Clear();
        }

        private void btn_voltprof_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_alprof_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtid.Text);
            Professor p = dao.BuscaPorId(Id);
            p.CarteiraTrab=txt_CdT.Text;
            p.CPF=int.Parse(txt_CPF.Text);
            p.Email=txt_Email.Text;
            p.Enderaco=txt_End.Text;
             p.FaixaComiss=double.Parse(txt_Faixa.Text);
            p.DataNasc=txt_Nasc.Text;
            p.Nome=txt_Nome.Text;
            p.RG=txt_RG.Text;
            p.Telefone=int.Parse(txt_Tel.Text);
            p.Login=txtLogin.Text;
            p.Senha=txtSenha.Text;
            p.IdMat = int.Parse(txtIdMat.Text);
            dao.Alt();
            btn_limpprof_Click(sender, e);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtid.Text);
                Professor p = dao.BuscaPorId(Id);
                txt_CdT.Text = p.CarteiraTrab;
                txt_CPF.Text = p.CPF.ToString();
                txt_Email.Text = p.Email;
                txt_End.Text = p.Enderaco;
                txt_Faixa.Text = p.FaixaComiss.ToString();
                txt_Nasc.Text = p.DataNasc;
                txt_Nome.Text = p.Nome;
                txtIdMat.Text = p.IdMat.ToString();
                txtLogin.Text = p.Login;
                txtSenha.Text = p.Senha;
                txt_RG.Text = p.RG.ToString();
                txt_Tel.Text = p.Telefone.ToString();
                txt_CdT.Enabled = true;
                txt_CPF.Enabled = true;
                txt_Email.Enabled = true;
                txt_End.Enabled = true;
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
                txt_Faixa.Enabled = true;
                txt_Nasc.Enabled = true;
                txt_Nome.Enabled = true;
                txtIdMat.Enabled = true;
                txt_RG.Enabled = true;
                txt_Tel.Enabled = true;
                btn_alprof.Enabled = true;
                btn_limpprof.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Não Existe com este Id");
            }
        }
    }
}

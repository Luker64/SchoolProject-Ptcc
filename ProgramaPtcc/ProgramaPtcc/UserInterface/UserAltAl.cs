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
    public partial class UserAltAl : UserControl
    {
        
        AlunoDAO DAO = new AlunoDAO();
        public UserAltAl()
        {
            InitializeComponent();
        }

        private void btn_limpal_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtb_email.Clear();
            txtb_id.Clear();
            txtb_nome.Clear();
            txtb_nomeresp.Clear();
           txtb_tel.Clear();
          txtb_turma.Clear();
        }

        private void btn_voltal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_altal_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtid.Text);
            Aluno a = DAO.BuscaPorId(Id);
            a.Email = txtb_email.Text;
            a.Idade = int.Parse(txtb_id.Text);
            a.Nome = txtb_nome.Text;
            a.NomeResp = txtb_nomeresp.Text;
            a.Telefone = int.Parse(txtb_tel.Text);
            a.CodTurma = int.Parse(txtb_turma.Text);
            DAO.Alt();
            btn_limpal_Click(sender, e);
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtid.Text);
                Aluno a = DAO.BuscaPorId(Id);
                txtb_email.Text = a.Email;
                txtb_id.Text = a.Idade.ToString();
                txtb_nome.Text = a.Nome;
                txtb_nomeresp.Text = a.NomeResp;
                txtb_tel.Text = a.Telefone.ToString();
                txtb_turma.Text = a.CodTurma.ToString();
                txtb_email.Enabled = true;
                txtb_id.Enabled = true;
                txtb_nome.Enabled = true;
                txtb_nomeresp.Enabled = true;
                txtb_tel.Enabled = true;
                txtb_turma.Enabled = true;
                btn_altal.Enabled = true;
                btn_limpal.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Não Existe com este Id");
            }
        }       
    }
}

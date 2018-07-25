using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaPtcc.Entidades;

namespace ProgramaPtcc
{
    public partial class Login : Form
    {
        Color red = Color.Red;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOlho_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string pass = txtPass.Text;
            string log = txtLog.Text;
            ProfessorDAO pro = new ProfessorDAO();
            bool check = pro.Login(log, pass);
            if (check)
            {
                this.Hide();
                Global.F1.Show();
            }
            else
            {
                pcbLog.BackColor = red;
                pcbPass.BackColor = red;
                lblErro.Visible = true;
                txtLog.Focus();
                txtLog.SelectAll();
                txtPass.Clear();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLog.Focus();
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using ProgramaPtcc.Entidades;

namespace ProgramaPtcc
{
    public partial class Form1 : Form
    {
        Color col = Color.FromArgb(50, 100, 200);
        Color scol = Color.Transparent;
        Color scol1=Color.FromArgb(153,180, 200);
        Color col1 = Color.FromArgb(170, 200, 220);
        public Form1()
        {
            InitializeComponent();

            escondeUser();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslbl.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void plcad_Click(object sender, EventArgs e)
        {
            escondeUser();
            corCli();
            plcad.BackColor = col1;
            if (pnlcad.Visible == false)
            {
                fecharAbas();

                pnlcad.Visible = true;

            }
            else
            {
                fecharAbas();
            }
        }

        private void plpesq_Click(object sender, EventArgs e)
        {
            escondeUser();
            corCli();
            fecharAbas();
            plpesq.BackColor = col1;
            userCons1.Visible = true;
            userCons1.BringToFront();
        }

        private void plbol_Click(object sender, EventArgs e)
        {
            escondeUser();
            corCli();
            fecharAbas();
            plbol.BackColor = col1;
            userBoletim1.Visible = true;
            userBoletim1.BringToFront();
        }

        private void plhor_Click(object sender, EventArgs e)
        {
            escondeUser();
            corCli();
            fecharAbas();
            plhor.BackColor = col1;
            userHorario1.Visible = true;
            userHorario1.BringToFront();
        }

        private void plalt_Click(object sender, EventArgs e)
        {
            escondeUser();
            corCli();
            plalt.BackColor = col1;
            if (pnlalt.Visible == false)
            {
                fecharAbas();
           
                pnlalt.Visible = true;
            }
            else
            {
                fecharAbas();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void btncadalu_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btncadalu.FlatAppearance.BorderSize = 0;
            pcbcadalclick.BackColor = col;
            escondeUser();
            userCadAlu1.Visible = true;

        }
       
        private void btncadfunc_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btncadfunc.FlatAppearance.BorderSize = 0;
            pcbcadfuncclick.BackColor = col;
            escondeUser();
            userCadFunc1.Visible = true;
        }

        private void btncadprof_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btncadprof.FlatAppearance.BorderSize = 0;
            pcbcadprofclick.BackColor = col;
            escondeUser();
            userCadProf1.Visible = true;
        }

        private void btncadmat_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btncadmat.FlatAppearance.BorderSize = 0;
            pcbcadmatclick.BackColor = col;
            escondeUser();
            userMat1.Visible = true;
        }

        private void btncadtur_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btncadtur.FlatAppearance.BorderSize = 0;
            pcbcadturclick.BackColor = col;
            escondeUser();
            userTur1.Visible = true;
        }

        private void btncadbol_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btncadbol.FlatAppearance.BorderSize = 0;
            pcbcadbolclick.BackColor = col;
            escondeUser();
            userBol1.Visible = true;
        }

        private void btnalal_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btnalal.FlatAppearance.BorderSize = 0;
            pcbalal.BackColor = col;
            escondeUser();
            userAltAl1.Visible = true;
        }

        private void btnalfun_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btnalfun.FlatAppearance.BorderSize = 0;
            pcbalfun.BackColor = col;
            escondeUser();
            userAltFunc1.Visible = true;
        }

        private void btnalprof_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btnalprof.FlatAppearance.BorderSize = 0;
            pcbalprof.BackColor = col;
            escondeUser();
            userAltProf1.Visible = true;
        }

        private void btnalmat_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btnalmat.FlatAppearance.BorderSize = 0;
            pcbalmat.BackColor = col;
            escondeUser();
            userAltMat1.Visible = true;
        }

        private void btnaltur_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btnaltur.FlatAppearance.BorderSize = 0;
            pcbaltur.BackColor = col;
            escondeUser();
            userAltTur1.Visible = true;
        }

        private void btnalbol_Click(object sender, EventArgs e)
        {
            fecharTabs();
            btnalbol.FlatAppearance.BorderSize = 0;
            pcbalbol.BackColor = col;
            escondeUser();
            userAltBol1.Visible = true;
        }
        

     
        public void fecharAbas()
        {

            pnlcad.Visible = false;
            pnlalt.Visible = false;

        }
        public void corCli()
        {
            plalt.BackColor = scol1;
            plbol.BackColor = scol1;
            plcad.BackColor = scol1;
            plhor.BackColor = scol1;
            plpesq.BackColor = scol1;
        }
        public void fecharTabs()
        {
            btncadalu.FlatAppearance.BorderSize = 1;
            pcbcadalclick.BackColor = scol;
            btncadfunc.FlatAppearance.BorderSize = 1;
            pcbcadfuncclick.BackColor = scol;
            btncadbol.FlatAppearance.BorderSize = 1;
            pcbcadbolclick.BackColor = scol;
            btncadmat.FlatAppearance.BorderSize = 1;
            pcbcadmatclick.BackColor = scol;
            btncadtur.FlatAppearance.BorderSize = 1;
            pcbcadturclick.BackColor = scol;
            btncadprof.FlatAppearance.BorderSize = 1;
            pcbcadprofclick.BackColor = scol;
            btnalal.FlatAppearance.BorderSize = 1;
            pcbalal.BackColor = scol;
            btnalfun.FlatAppearance.BorderSize = 1;
            pcbalfun.BackColor = scol;
            btnalbol.FlatAppearance.BorderSize = 1;
            pcbalbol.BackColor = scol;
            btnalmat.FlatAppearance.BorderSize = 1;
            pcbalmat.BackColor = scol;
            btnaltur.FlatAppearance.BorderSize = 1;
            pcbaltur.BackColor = scol;
            btnalprof.FlatAppearance.BorderSize = 1;
            pcbalprof.BackColor = scol;
        }
        private void escondeUser()
        {
            userAltAl1.Visible = false;
            userAltBol1.Visible = false;
            userAltFunc1.Visible = false;
            userAltMat1.Visible = false;
            userAltProf1.Visible = false;
            userAltTur1.Visible = false;
            userBol1.Visible = false;
            userCadAlu1.Visible = false;
            userCadFunc1.Visible = false;
            userCadProf1.Visible = false;
            userMat1.Visible = false;
            userTur1.Visible = false;
            userCons1.Visible = false;
            userBoletim1.Visible = false;
            userHorario1.Visible = false;
        }

        private void plalt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plpesq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plbol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userCons1_Load(object sender, EventArgs e)
        {

        }
    }
}

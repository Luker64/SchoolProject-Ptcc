using System;
using System.Windows.Forms;

namespace ProgramaPtcc
{
    public partial class Splash : Form
    {
        
        public Splash()
        {
            InitializeComponent();
        }

        private void timersplash_Tick(object sender, EventArgs e)
        {
          
            Global.LOG.Show();
            this.Hide();
            timersplash.Enabled = false;
            
        }

        
    }
}

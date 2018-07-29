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

        int i = 0;
        private void timersplash_Tick(object sender, EventArgs e)
        {
           i += 2;
            mPB1.Value += 2;
          if(i >= 100)
            {
                Global.LOG.Show();
                this.Hide();
                timersplash.Enabled = false;
            }
            
            
        }

        
    }
}

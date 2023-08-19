using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacare
{
    public partial class SplashScreen : Form
    {
        int progress = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress++;

            if (progress > 100)
            {
                timer1.Enabled = false;
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
                return;  
            }

            progressBar1.Value = progress;
            label2.Text = progress + "%";

        }
    }
}

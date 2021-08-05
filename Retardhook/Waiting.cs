using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Retardhook
{
    public partial class Waiting : Form
    {
        public Waiting()
        {
            InitializeComponent();
        }

        Timer t1 = new Timer();

        private void Waiting_Load(object sender, EventArgs e)
        {
            injectTimer.Start();
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();
            else
                Opacity += 0.01;
        }

        private void injectTimer_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("oOMSfFPdHCcGSFECCtiQKcKjXCrtYtdonhfwzrfROTzyiuzZdLXHXrgLDcucNWEO");
            if (pname.Length == 0)
            {
                return;
            }
            else
            {
                injectTimer.Stop();
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void Waiting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

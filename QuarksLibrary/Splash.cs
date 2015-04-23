using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarksLibrary
{
    public partial class Splash : Form
    {
        private int timeLeft;
        public Splash()
        {
            timeLeft = 2;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            InitializeComponent();
            splashTimer.Start();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                splashProgress.PerformStep();
            }
            else
            {
                splashTimer.Stop();
                Thread thread = new Thread(startMain);
                thread.Start();
                this.Close();
            }
        }
        private void startMain()
        {
            Application.Run(new QuarksMain());
        }
    }
}

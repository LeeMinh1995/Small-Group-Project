using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Algorithms
{
    public partial class CountingSundayForm : Form
    {
        public CountingSundayForm()
        {
            InitializeComponent();
        }
        #region Main menu button event
        private void backBtn_Click(object sender, EventArgs e)
        {
            timerFader.Start();
        }
        #endregion
        #region Fade Out Effect
        private void timerFader_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                MainForm mf = new MainForm();
                timerFader.Stop();
                this.Hide();
                mf.Show();
            }
            else
            {
                this.Opacity -= .04;
                this.Refresh();
            }
        }
        #endregion  
        #region
        private void startBtn_Click(object sender, EventArgs e)
        {
            CountingSunday cs = new CountingSunday();

            Stopwatch watch = Stopwatch.StartNew();

            answerResult.Text = "The number of Sunday : " + cs.Main();

            watch.Stop();

            var time = watch.Elapsed;

            timeLabel.Text = "Total time of algorithm : " + time.TotalMilliseconds + " ms";
        }
        #endregion
    }
}

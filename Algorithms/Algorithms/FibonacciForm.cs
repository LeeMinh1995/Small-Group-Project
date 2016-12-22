using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Numerics;

namespace Algorithms
{
    public partial class FibonacciForm : Form
    {
        Random rand = new Random();

        public FibonacciForm()
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
        #region Start button event
        private void startBtn_Click(object sender, EventArgs e)
        {
            Fibonacci f = new Fibonacci();
            
            int value = rand.Next(10,1000);

            inputLabel.Text = "Input (n) : " + value;

            Stopwatch watch = Stopwatch.StartNew();

            fibonacciOutput.Text = f.Main(value).ToString();

            watch.Stop();

            var time = watch.Elapsed;

            timeLabel.Text = "Total time of algorithm : " + time.TotalMilliseconds + " ms";
        }
        #endregion
    }
}

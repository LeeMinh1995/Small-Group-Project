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
    public partial class GDCForm : Form
    {
        Random rand = new Random();

        public GDCForm()
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
        #region Execute button event
        private void executeBtn_Click(object sender, EventArgs e)
        {
            /* Call a class GDC */
            GDC gdc = new GDC();
            /* Add random integer value to two integer variables */
            int valOne = rand.Next(1, 1000);
            int valTwo = rand.Next(1, 1000);
            /* Show value to form */
            intOne.Text = "Number a = " + valOne;
            intTwo.Text = "Number b = " + valTwo;
            /* Start counting */
            Stopwatch watch = Stopwatch.StartNew();
            /* Calculate a gcd of two integer numbers */
            outputLabel.Text = "=> GCD(a , b) = " + gdc.Main(valOne, valTwo);
            /* Stop counting */
            watch.Stop();
            /* Print out the time execution of an algorithm */
            var time = watch.Elapsed;

            timeLabel.Text = "Total time of algorithm : " + time.TotalMilliseconds + " ms";
        }
        #endregion
    }
}

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
    public partial class BruteForceStringMatchForm : Form
    {
        public BruteForceStringMatchForm()
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
        #region Find button event
        private void findBtn_Click(object sender, EventArgs e)
        {
            /* Call a class BruteForceStringMatch */
            BruteForceStringMatch bfsm = new BruteForceStringMatch();
            /* Turn text container into default mode */
            textContainer.Text = bfsm.text;
            /* Start counting */
            Stopwatch watch = Stopwatch.StartNew();
            /* Get return value of an algorithm */
            int value = bfsm.Main(patternTxt.Text);
            /* Stop counting */
            watch.Stop();
            /* Get a length of the pattern */
            int strLength = patternTxt.Text.Length;
            /* Check if return value is different with negative 1 */
            if (value != -1)
            {
                /* Highlighted the string if it is found */
                textContainer.SelectionStart = value;
                textContainer.SelectionLength = strLength;
                textContainer.SelectionFont = new Font("Consolas", 11, FontStyle.Bold);
                textContainer.SelectionColor = Color.Red;
                /* Print out the answer */
                answerResult.ForeColor = Color.Green;
                answerResult.Text = "YES";
            }
            else
            {
                /* Print out the answer */
                answerResult.ForeColor = Color.Red;
                answerResult.Text = "NO";
            }
            var time = watch.Elapsed;
            /* Print out an execution time of an algorithm */
            timeLabel.Text = "Total time of algorithm : " + time.TotalMilliseconds + " ms";
        }
        #endregion
    }
}

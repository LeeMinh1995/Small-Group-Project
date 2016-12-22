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
    public partial class LargestProductInASeriesForm : Form
    {
        public LargestProductInASeriesForm()
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
            LargestProductInASeries lpias = new LargestProductInASeries();

            Stopwatch watch = Stopwatch.StartNew();

            string[] result = lpias.Main().Split(' ');

            watch.Stop();

            var time = watch.Elapsed;

            timeLabel.Text = "Total time of algorithm : " + watch.ElapsedMilliseconds + " ms";

            answer.Text = "The value is : " + result[0];

            series.SelectionStart = int.Parse(result[1]);

            series.SelectionLength = 13;

            series.SelectionColor = Color.Red;           
        }
        #endregion
    }
}

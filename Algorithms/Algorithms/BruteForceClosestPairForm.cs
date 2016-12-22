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
    public partial class BruteForceClosestPairForm : Form
    {
        Random rand = new Random();

        float[] P;

        public BruteForceClosestPairForm()
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
        #region Generate button event
        private void generateBtn_MouseClick(object sender, MouseEventArgs e)
        {
            P = new float[rand.Next(6, 14) * 2];

            totalPointLabel.Text = "Total point : " + P.Length / 2;

            pointContainer.Visible = true;

            AddValueToArray(P);

            pointContainer.Invalidate();                           
        }
        #endregion
        #region Draw the dot on the screen
        private void pointContainer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pointContainer.CreateGraphics();

            SolidBrush sb = new SolidBrush(Color.Black);

            for (int i = 0; i < P.Length; i+=2)
            {           
                g.FillEllipse(sb, P[i], P[i+1], 8, 8);
            }        
        }
        #endregion
        #region Add value to an array
        private void AddValueToArray(float[] P)
        {
            for (int i = 0; i < P.Length; i += 2)
            {
                P[i] = rand.Next(10, 630);
            }
            for (int j = 1; j <= P.Length - 1; j += 2)
            {
                P[j] = rand.Next(5, 220);
            }
        }
        #endregion
        #region Find button event
        private void findBtn_Click(object sender, EventArgs e)
        {
            // Call class BruteForceClosestPair
            BruteForceClosestPair bfcp = new BruteForceClosestPair();
            // Gain return value from method
            string resultStr = bfcp.Main(P, P.Length);
            // Split all the value from return value and put it to an array
            string[] closestPairVal = resultStr.Split(' ');
            // This variable represent for Xi
            string pointXi = closestPairVal[1];
            // This variable represent for Xj
            string pointXj = closestPairVal[2];
            // Start counting
            Stopwatch watch = Stopwatch.StartNew();
            // Print the value to screen d = Sqrt( (Xi - Xj)^2 + (Yi - Yj)^2 )
            answerLabel.Text = "The closest pair is : " + closestPairVal[0];
            // Stop counting
            watch.Stop();

            var time = watch.Elapsed;
            // Print out an execution time
            timeLabel.Text = "Total time of algorithm : " + time.TotalMilliseconds + " ms";
            // Paint closest pair into red colour
            Graphics g = pointContainer.CreateGraphics();

            SolidBrush sb = new SolidBrush(Color.Red);
            // This is the painting of A(Xi,Yi)
            g.FillEllipse(sb, P[Int32.Parse(pointXi)], P[Int32.Parse(pointXi) + 1], 8, 8);
            // This is the painting of B(Xj,Yj)
            g.FillEllipse(sb, P[Int32.Parse(pointXj)], P[Int32.Parse(pointXj) + 1], 8, 8);
        }
        #endregion
    }
}

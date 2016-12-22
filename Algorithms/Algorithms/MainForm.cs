using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Algorithms
{
    public partial class MainForm : XtraForm
    {
        string algorithmBtnDetect = "";

        public MainForm()
        {
            InitializeComponent();
        }
        #region Close button event
        private void closeBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Minimize button event
        private void minBtn_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion              
        #region Fade Out Effect
        private void timerFader_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                timerFader.Stop();
                this.Hide();
                OpenForm();
            }
            else
            {
                this.Opacity -= .04;
                this.Refresh();
            }
        }
        #endregion

        private void OpenForm()
        {
            switch (algorithmBtnDetect)
            {
                case "sum":
                    SumForm sf = new SumForm();
                    sf.Show();
                    break;
                case "horner":
                    HornerForm hf = new HornerForm();
                    hf.Show();
                    break;
                case "fibonacci":
                    FibonacciForm ff = new FibonacciForm();
                    ff.Show();
                    break;
                case "largest":
                    LargestProductInASeriesForm lpiasf = new LargestProductInASeriesForm();
                    lpiasf.Show();
                    break;
                case "sunday":
                    CountingSundayForm csf = new CountingSundayForm();
                    csf.Show();
                    break;
                case "stringmatch":
                    BruteForceStringMatchForm bfsmf = new BruteForceStringMatchForm();
                    bfsmf.Show();
                    break;
                case "selection":
                    SelectionSortForm ssf = new SelectionSortForm();
                    ssf.Show();
                    break;
                case "gcd":
                    GDCForm gcdf = new GDCForm();
                    gcdf.Show();
                    break;
                case "closestpair":
                    BruteForceClosestPairForm bfcpf = new BruteForceClosestPairForm();
                    bfcpf.Show();
                    break;
                case "uniqueness":
                    PresortElementUniquenessForm peuf = new PresortElementUniquenessForm();
                    peuf.Show();
                    break;
                default:
                    break;
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "sum";
            timerFader.Start();
        }

        private void presortElementUniqueness_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "uniqueness";
            timerFader.Start();
        }

        private void selectionSort_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "selection";
            timerFader.Start();
        }

        private void bruteForceStringMatch_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "stringmatch";
            timerFader.Start();
        }

        private void fibonacci_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "fibonacci";
            timerFader.Start();
        }

        private void horner_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "horner";
            timerFader.Start();
        }

        private void lcm_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "gcd";
            timerFader.Start();
        }

        private void closestPair_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "closestpair";
            timerFader.Start();
        }

        private void largestProduct_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "largest";
            timerFader.Start();
        }

        private void countingSunday_Click(object sender, EventArgs e)
        {
            algorithmBtnDetect = "sunday";
            timerFader.Start();
        }
    }
}
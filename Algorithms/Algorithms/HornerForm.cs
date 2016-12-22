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
    public partial class HornerForm : Form
    {
        Random rand = new Random();
        int[] a;

        public HornerForm()
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
        private void generateArray_Click(object sender, EventArgs e)
        {
            a = new int[rand.Next(3, 10)];

            AddValueToArray(a);

            PrintFormula(a);

            xValue.Text = "Give X = ";
        }
        #endregion
        #region Add value to an array
        private void AddValueToArray(int[] a)
        {
            int value = 0, i = 0;

            while (i < a.Length)
            {
                value = rand.Next(-25, 25);

                if (value != 0)
                {
                    a[i] = value;

                    i++;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion
        #region Print Formula
        private void PrintFormula(int[] a)
        {
            hornerFormula.Text = "P(x) = ";

            for (int i = a.Length - 1; i > -1; i--)
            {
                if (i == a.Length - 1)
                {
                    if (a[i] == 1) hornerFormula.Text += "x" + SupperScript(i);
                    else if (a[i] == -1) hornerFormula.Text += "-x" + SupperScript(i);
                    else if (a[i] > 0) hornerFormula.Text += a[i] + "x" + SupperScript(i);
                    else hornerFormula.Text += "-" + ReserverValue(a[i]) + "x" + SupperScript(i);
                }
                else if (i == 0)
                {
                    if (a[i] > 0) hornerFormula.Text += " + " + a[i];
                    else hornerFormula.Text += " - " + ReserverValue(a[i]);
                }
                else
                {
                    if (a[i] == 1) hornerFormula.Text += " + x" + SupperScript(i);
                    else if (a[i] == -1) hornerFormula.Text += " - x" + SupperScript(i);
                    else if (a[i] > 0) hornerFormula.Text += " + " + a[i] + "x" + SupperScript(i);
                    else hornerFormula.Text += " - " + ReserverValue(a[i]) + "x" + SupperScript(i);
                }
            }
        }
        #endregion
        #region Supperscript letter
        private string SupperScript(int value)
        {
            switch (value)
            {
                case 1:
                    return "";
                    break;
                case 2:
                    return "²";
                    break;
                case 3:
                    return "³";
                    break;
                case 4:
                    return "⁴";
                    break;
                case 5:
                    return "⁵";
                    break;
                case 6:
                    return "⁶";
                    break;
                case 7:
                    return "⁷";
                    break;
                case 8:
                    return "⁸";
                    break;
                case 9:
                    return "⁹";
                    break;
                case 10:
                    return "¹⁰";
                    break;
                default:
                    break;
            }
            return "";
        }
        #endregion
        #region Reserver value
        private int ReserverValue(int value)
        {
            return (-value);
        }
        #endregion
        #region Calculate button event
        private void calBtn_Click(object sender, EventArgs e)
        {
            Horner h = new Horner();

            if (String.IsNullOrEmpty(xValueInput.Text))
            {
                hornerResult.Text = "P(X) = 0";
            }
            else
            {
                Stopwatch watch = Stopwatch.StartNew();

                hornerResult.Text = "P(" + xValueInput.Text + ") = " + h.Main(a, Int32.Parse(xValueInput.Text));

                watch.Stop();

                var time = watch.Elapsed;

                timeLabel.Text = "Total time of algorithm : " + time.TotalMilliseconds + " ms";
            }
        }       
        #endregion
    }
}

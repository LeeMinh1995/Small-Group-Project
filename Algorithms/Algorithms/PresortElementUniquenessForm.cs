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
    public partial class PresortElementUniquenessForm : Form
    {
        Random rand = new Random();
        int[] array;
        //int[] arrayTemp = { 19 , 25 , 64 , 113 , 23 , 1 , 6 , 6 , 71 , 95 , 10 , 4 , 8 , 166 };

        public PresortElementUniquenessForm()
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
        #region Add value to an array
        private void AddValueToArray(int[] array, int value)
        {
            Array.Clear(array, 0, value);

            for (int i = 0; i < value; i++)
            {
                array[i] = rand.Next(1, 2000000);
            }
        }
        #endregion
        #region Print an array before sorting
        private void PrintArrayPresort(int[] array)
        {
            foreach (var i in array)
            {
                arrayContainer.AppendText(i + " ");
            }
        }
        #endregion
        #region Print an array after sorting
        private void PrintArraySubsort(int[] array)
        {
            arrayContainer.Text = "";

            foreach (var i in array)
            {
                arrayContainer.AppendText(i + " ");
            }
        }
        #endregion
        #region Generate button event
        private void generateArray_Click(object sender, EventArgs e)
        {
            /* Clear an array container */
            arrayContainer.Text = "";
            /* Create a random length for an array */
            int value = rand.Next(10, 1000);
            /* Create an array */
            array = new int[value];
            /* Call a method CreateArray() to add value to an array */
            AddValueToArray(array, value);
            /* Print out an array after value are added */
            PrintArrayPresort(array);
        }
        #endregion
        #region Scan button event		TicksPerSecond	10000000	long

        private void scanBtn_Click(object sender, EventArgs e)
        {            
            /* Call a class PresortElementUniqueness */
            PresortElementUniqueness peu = new PresortElementUniqueness();
            /* Start counting */
            Stopwatch watch = Stopwatch.StartNew();
            /* Gain a return value to variable */
            int value = peu.Main(array);
            /* Stop counting */
            watch.Stop();
            /* Print an array after sorting for checking element */
            PrintArraySubsort(array);
            /* Check if an array is unique or not */
            if (value == -1)
            {
                answerResult.Text = "YES";
                answerResult.ForeColor = Color.Green;
            }
            else
            {
                answerResult.Text = "NO";
                answerResult.ForeColor = Color.Red;
                /* Call FindElementInArray method */
                FindElementInArray(value);
            }
            var time = watch.Elapsed;
            /* Print out an execution time */
            timeLabel.Text = "Total time of algorithm : " + time.TotalMilliseconds + " ms";
        }
        #endregion
        #region Find an element in an array
        private void FindElementInArray(int value)
        {
            /* Get a position of an element in an array by using IndexOf method */
            int valuePosition = arrayContainer.Text.IndexOf(array[value].ToString());
            /* Get length of an value */
            int valueLength = array[value].ToString().Length;
            /* Select an value in an array */
            arrayContainer.SelectionStart = valuePosition;
            /* Selecting bases on value length */
            arrayContainer.SelectionLength = valueLength;
            /* Highlight the value */
            arrayContainer.SelectionColor = Color.Red;
        }
        #endregion
    }
}

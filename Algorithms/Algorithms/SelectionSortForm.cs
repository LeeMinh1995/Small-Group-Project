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
    public partial class SelectionSortForm : Form
    {
        Random rand = new Random();
        int[] array;

        public SelectionSortForm()
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
            foreach (var i in array)
            {
                arrayResult.AppendText(i + " ");
            }
        }
        #endregion
        #region Sort array button event
        private void sortArrayBtn_Click(object sender, EventArgs e)
        {            
            /* Call class selection sort */
            SelectionSort ss = new SelectionSort();
            /* Start counting an algorithm */
            Stopwatch watch = Stopwatch.StartNew();
            /* Call an algorithm */
            ss.Main(array);
            /* Stop counting */
            watch.Stop();
            /* Print out the time execution of an algorithm */
            var time = watch.Elapsed;

            timeLabel.Text = "Total time of algorithm : " + time.TotalMilliseconds + " ms";
            /* Print out an array after sorted */
            PrintArraySubsort(array);
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
    }
}

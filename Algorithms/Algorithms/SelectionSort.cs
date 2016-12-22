using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class SelectionSort
    {
        int temp = 0;

        public void Main(int[] A)
        {
            int min = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[min])
                    {
                        min = j;
                    }
                }

                temp = A[i];
                A[i] = A[min];
                A[min] = temp;
            }
        }
    }
}

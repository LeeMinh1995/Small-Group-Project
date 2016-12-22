using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class MergeSort
    {
        public void MergeSortAlgorithm(int[] A, int p, int r)
        {
            int q = 0;

            if (p < r)
            {
                double value = (p + r) / 2;

                q = (int) Math.Round(value);

                MergeSortAlgorithm(A, p, q);
                MergeSortAlgorithm(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }
        private void Merge(int[] A, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];

            for (int i = 1; i < n1; i++)
            {
                L[i] = A[p + i - 1];
            }
            for (int j = 1; j < n2; j++)
            {
                R[j] = A[q + j];
            }

            L[n1 + 1] = 0;
            R[n2 + 1] = 0;

            int a = 1, b = 1;

            for (int k = p; k < r; k++)
            {
                if (L[a] <= R[b])
                {
                    A[k] = L[a];
                    a = a + 1;
                }
                else
                {
                    A[k] = R[b];
                    b = b + 1;
                }
            }
        }
    }
}

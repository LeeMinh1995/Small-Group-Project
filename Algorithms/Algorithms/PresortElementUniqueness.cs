using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class PresortElementUniqueness
    {
        public int Main(int[] A)
        {
            return AlgorithmDesign(A);
        }
        private int AlgorithmDesign(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i < A.Length - 2; i++)
            {
                if (A[i] == A[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

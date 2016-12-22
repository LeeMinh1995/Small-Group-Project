using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class Horner
    {
        public Int64 Main(int[] a, int x)
        {
            return AlgorithmDesign(a , x);
        }
        private Int64 AlgorithmDesign(int[] a, int x)
        {
            Int64 p = a [ a.Length - 1 ];

            for (int i = a.Length - 2; i > -1; i--)
            {
                p = x * p + a[i];
            }

            return p;
        }
    }
}

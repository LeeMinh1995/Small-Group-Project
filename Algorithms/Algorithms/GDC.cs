using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class GDC
    {
        public int Main(int m, int n)
        {
            return (n * m) / AlgorithmDesign(m, n);
        }
        private int AlgorithmDesign(int m, int n)
        {
            int r = 0;

            while (n != 0)
            {
                r = m % n;
                m = n;
                n = r;
            }

            return m;
        }
    }
}

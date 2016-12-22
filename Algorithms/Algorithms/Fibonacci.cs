using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Algorithms
{
    class Fibonacci
    {
        public BigInteger Main(int n)
        {
            return AlgorithmDesign(n);
        }
        private BigInteger AlgorithmDesign(int n)
        {
            BigInteger[] f = new BigInteger[n];

            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i < n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n - 1];
        }
    }
}

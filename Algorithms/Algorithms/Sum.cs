using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class Sum
    {
        public Int64 Main(Int32 N)
        {
            return AlgorithmDesign(N);
        }
        private Int64 AlgorithmDesign(Int32 N)
        {
            Int64 S = 0;

            for (int i = 0; i < N; i++)
            {
                S = S + (i * i);
            }

            return S;
        }
    }
}

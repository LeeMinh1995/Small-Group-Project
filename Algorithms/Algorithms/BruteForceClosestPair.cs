using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class BruteForceClosestPair
    {
        double bigNumber = 999999999999;

        public string Main(float[] P, int n)
        {
            return AlgorithmDesign(P, n);
        }
        private string AlgorithmDesign(float[] P, int n)
        {
            double d = bigNumber;

            int pointXi = 0, pointXj = 0;

            for (int i = 0; i < n - 3; i+=2)
            {
                for (int j = i + 2; j < n - 1; j+=2)
                {
                    //d = Min(d, Math.Sqrt(Math.Pow(P[i] - P[i + 2], 2) + Math.Pow(P[j] - P[j + 2], 2)));
                    
                    double value = Math.Sqrt(Math.Pow(P[i] - P[j], 2) + Math.Pow(P[i + 1] - P[j + 1], 2));

                    if (value < d)
                    {
                        d = value;

                        pointXi = i;

                        pointXj = j;
                    }
                }           
            }

            return d + " " + pointXi + " " + pointXj;
        }

        private double Min(double a, double b)
        {
            return a < b ? a : b;
        }
    }
}

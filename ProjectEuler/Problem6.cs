using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6
    {
        public static double Solve()
        {
            double sumSquares = 0;
            double squareSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumSquares += Math.Pow(i, 2);
                squareSum += i;
            }
            squareSum = Math.Pow(squareSum, 2);

            return Math.Abs(sumSquares - squareSum);
        }
    }
}

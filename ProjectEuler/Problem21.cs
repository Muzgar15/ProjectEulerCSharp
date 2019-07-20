using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem21
    {
        public static long Solve()
        {
            long sum = 0;
            long sumFirst = 0;
            long sumSecond = 0;
            for (int i = 1; i < 10000; i++)
            {
                sumFirst = 0;
                sumSecond = 0;
                // we get the divisors of i and add them together
                long[] divisors = Toolbox.GetDivisors(i);
                for (int j = 0; j < divisors.Length - 1; j++)
                {
                    sumFirst += divisors[j];
                }
                // if the sum of divisors is not equal to the number itself we can continue
                if (sumFirst != i)
                {
                    // we get the divisors of the previous sum
                    divisors = Toolbox.GetDivisors(sumFirst);
                    for (int j = 0; j < divisors.Length - 1; j++)
                    {
                        sumSecond += divisors[j];
                    }
                    // if the second sum matches the original number, the number is considered to be amicable
                    if (sumSecond == i)
                    {
                        sum += sumFirst + i;
                    }
                }
            }
            // we divide the result by 2, because we added each number of the pair twice
            return sum/2;
        }
    }
}

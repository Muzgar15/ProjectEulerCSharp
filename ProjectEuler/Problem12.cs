using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem12
    {
        public static long Solve()
        {
            long[] divisors = new long[] { };
            int num = 1;
            int counter = 2;
            while(divisors.Length <= 500)
            {
                num += counter;
                counter++;
                divisors = Toolbox.GetDivisors(num);
            }
            return num;
        }
    }
}

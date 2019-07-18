using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem10
    {
        public static long Solve()
        {
            long sum = 0;
            for(int i = 2; i < 2000000; i++)
            {
                if (Toolbox.IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}

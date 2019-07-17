using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2
    {
        public static int Solve()
        {
            int fibSmall = 1;
            int fibLarge = 1;
            int temp;
            int sum = 0;
            while (fibLarge < 4000000)
            {
                temp = fibLarge;
                fibLarge += fibSmall;
                fibSmall = temp;

                if (fibLarge % 2 == 0)
                {
                    sum += fibLarge;
                }
            }
            return sum;
        }
    }
}

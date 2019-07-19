using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem14
    {
        public static long Solve()
        {
            long num = 1;
            int counter = 1;
            long max = 1;
            long maxNum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                counter = 1;
                num = i;
                while (num != 1)
                {
                    counter++;
                    if (num % 2 == 0)
                    {
                        num /= 2;
                    }
                    else
                    {
                        num = 3 * num + 1;
                    }
                }
                if(counter > max)
                {
                    max = counter;
                    maxNum = i;
                }
            }
            return maxNum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem5
    {
        public static long Solve()
        {
            long ret = 0;
            bool isDivisibleByAll = false;
            long num = 20;
            while (!isDivisibleByAll)
            {
                isDivisibleByAll = true;
                for (int i = 1; i <= 20; i++)
                {
                    if (num % i != 0)
                    {
                        isDivisibleByAll = false;
                        break;
                    }

                }
                if (isDivisibleByAll)
                {
                    ret = num;
                }
                num++;
            }
            return ret;
        }
    }
}

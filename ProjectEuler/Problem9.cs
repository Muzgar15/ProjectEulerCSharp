using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem9
    {
        public static int Solve()
        {
            for(int i = 1; i <= 1000; i++)
            {
                for(int j = 1; j <= 1000; j++)
                {
                    for(int k = 1; k <= 1000; k++)
                    {
                        if(i+j+k == 1000)
                        {
                            if (Math.Pow(i, 2) + Math.Pow(j, 2) == Math.Pow(k, 2))
                            {
                                return i * j * k;
                            }
                        }
                    }
                }
            }
            return -1;
        }
    }
}

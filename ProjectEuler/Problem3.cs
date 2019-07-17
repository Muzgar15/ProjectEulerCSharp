using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class Problem3
    {
        public static long Solve()
        {
            long num = 600851475143;
            List<long> factors = new List<long>();
            while (num % 2 == 0)
            {
                num /= 2;
                if (!factors.Contains(2))
                {
                    factors.Add(2);
                }
            }

            for (int i = 3; i <= Math.Sqrt(num); i = i + 2)
            {
                while (num % i == 0)
                {
                    num /= i;
                    if (!factors.Contains(i))
                    {
                        factors.Add(i);
                    }
                }
            }
            if (num != 1)
            {
                factors.Add(num);
            }
            return factors.Max();
        }
    }
}

﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Toolbox
    {
        public static bool IsPalindrome(int mult)
        {
            String str = mult.ToString();

            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) != str.ElementAt(str.Length - i - 1))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPrime(long num)
        {
            if (num % 2 == 0)
            {
                if(num == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            for (int i = 3; i <= Math.Sqrt(num); i = i + 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static long[] GetDivisors(long num)
        {
            List<long> divisors = new List<long>();
            divisors.Add(1);
            divisors.Add(num);
            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    divisors.Add(i);
                    if (i != num / i)
                    {
                        divisors.Add(num / i);
                    }
                }
                
            }
            return divisors.ToArray();
        }
    }
}

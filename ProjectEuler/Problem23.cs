using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem23
    {
        public static long Solve()
        {
            // first we need to find all the abundant numbers up to cca. 28123 - just to be safe
            long[] divisors;
            long sum = 0;
            List<int> abundant = new List<int>();
            for(int i = 1; i < 28123; i++)
            {
                sum = 0;
                divisors = Toolbox.GetDivisors(i);
                for(int j = 0; j < divisors.Length-1; j++)
                {
                    sum += divisors[j];
                }
                if(sum > i)
                {
                    abundant.Add(i);
                }
            }

            // then we need to add each number in the set to each other to get all the possible numbers
            int first, second, third;
            List<int> validNumbers = new List<int>();
            for(int i = 0; i < abundant.Count; i++)
            {
                first = abundant.ElementAt(i);
                for(int j = 0; j < abundant.Count; j++)
                {
                    second = abundant.ElementAt(j);
                    third = first + second;
                    if(third < 28123)
                    {
                        validNumbers.Add(third);
                    }
                }
            }
            validNumbers = validNumbers.Distinct().ToList();

            sum = 0;
            // finally we need to check which numbers are not contained in the set and add them together
            for(int i = 1; i < 28123; i++)
            {
                if (!validNumbers.Contains(i))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}

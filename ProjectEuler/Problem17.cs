using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem17
    {
        public static int Solve()
        {
            String allNumbers = "";
            String hundred = "hundred";
            String thousand = "thousand";
            String and = "and";

            int temp = 0;
            String[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            for (int i = 1; i <= 1000; i++)
            {
                temp = i;
                if (i == 1000)
                {
                    allNumbers += numbers[1] + thousand;
                    temp = 0;
                }
                else if (i >= 100)
                {
                    allNumbers += numbers[i / 100];
                    allNumbers += hundred;
                    temp %= 100;
                    if (temp != 0)
                    {
                        allNumbers += and;
                    }
                }
                if (temp != 0)
                {
                    if (temp < 20)
                    {
                        allNumbers += numbers[temp];
                    }
                    else
                    {
                        allNumbers += numbers[(temp / 10) + 18];
                        temp %= 10;
                        if (temp != 0)
                        {
                            allNumbers += numbers[temp];
                        }

                    }
                }
                allNumbers += "\n";
            }
            return allNumbers.Length;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

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

        internal static string AddIntegerStrings(string result, string line)
        {
            if (Math.Abs(result.Length - line.Length) != 0)
            {
                int padding = Math.Abs(result.Length - line.Length);
                for(int i = 0; i < padding; i++)
                {
                    if(result.Length < line.Length)
                    {
                        result = "0" + result;
                    }
                    else
                    {
                        line = "0" + line;
                    }
                }
            }
            int firstDigit, secondDigit;
            int remainder = 0;
            int sum = 0;
            String temp = "";
            for(int i = line.Length-1; i >= 0; i--)
            {
                sum = 0;
                firstDigit = (int) Char.GetNumericValue(line[i]);
                secondDigit = (int) Char.GetNumericValue(result[i]);
                sum = firstDigit + secondDigit + remainder;
                remainder = sum / 10;
                if(sum >= 10)
                {
                    sum %= 10;
                }
                temp = sum.ToString() + temp;
            }
            if(remainder != 0)
            {
                temp = remainder.ToString() + temp;
            }

            return temp;
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

        public static long BinomialCoefficient(long num1, long num2)
        {
            long result = 1;
            if(num2 > num1)
            {
                result = 0;
                return result;
            }
            result = Factorial(num1)/(Factorial(num2)*Factorial(num1-num2));
            return result;
        }

        public static BigInteger BinomialCoefficientBig(long num1, long num2)
        {
            BigInteger result = new BigInteger(1);
            if (num2 > num1)
            {
                result = BigInteger.Zero;
                return result;
            }
            result = BigInteger.Divide(FactorialBig(num1),BigInteger.Multiply(FactorialBig(num2),FactorialBig(num1 - num2)));
            return result;
        }
        public static long Factorial(long num)
        {
            long result = 1;
            for(int i = 0; i < num; i++)
            {
                result *= i + 1;
            }
            return result;
        }

        public static BigInteger FactorialBig(long num)
        {

            BigInteger result = new BigInteger(1);
            for (int i = 0; i < num; i++)
            {
                result = BigInteger.Multiply(result, i + 1);
            }
            return result;
        }
    }
}

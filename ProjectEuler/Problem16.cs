using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Problem16
    {
        public static int Solve()
        {
            BigInteger num = new BigInteger(2);
            num = BigInteger.Pow(2, 1000);
            String number = num.ToString();
            int result = 0;
            for(int i = 0; i < number.Length; i++)
            {
                result += (int) Char.GetNumericValue((char) number[i]);
            }
            return result;
        }
    }
}

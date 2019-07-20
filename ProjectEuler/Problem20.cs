using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem20
    {
        public static int Solve()
        {
            String num = Toolbox.FactorialBig(100).ToString();
            int sum = 0;
            for(int i = 0; i < num.Length; i++)
            {
                sum += (int) Char.GetNumericValue(num[i]);
            }
            return sum;
        }
    }
}

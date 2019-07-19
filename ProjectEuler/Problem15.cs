using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem15
    {
        public static String Solve()
        {
            return Toolbox.BinomialCoefficientBig(40, 20).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

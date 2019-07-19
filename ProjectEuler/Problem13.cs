using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem13
    {
        public static String Solve()
        {
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ambroz\source\repos\ProjectEuler\ProjectEuler\Problem13.txt");
            String result = "0";
            String line;
            for (int i = 0; i < lines.Length; i++)
            {
                line = lines[i];
                result = Toolbox.AddIntegerStrings(line,result);
            }
            return result;
        }
    }
}

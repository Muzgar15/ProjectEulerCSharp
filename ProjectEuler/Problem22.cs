using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem22
    {
        public static int Solve()
        {
            // read file, split on ',', create list and sort it
            List<String> namesList = new List<string>(System.IO.File.ReadAllText("C:/Users/Ambroz/source/repos/ProjectEuler/ProjectEuler/p022_names.txt").Split(','));
            namesList.Sort();
            int score = 0;
            int total = 0;
            for(int i = 0; i < namesList.Count; i++)
            {
                score = 0;
                // leave out first and last char because they are quotation marks, add all other chars together
                for(int j = 1; j < namesList.ElementAt(i).Length-1; j++)
                {
                    // -64 because ASCII A = 65
                    score += namesList.ElementAt(i)[j] - 64;
                }
                score *= (i+1);
                total += score;
            }
            return total;
        }
    }
}

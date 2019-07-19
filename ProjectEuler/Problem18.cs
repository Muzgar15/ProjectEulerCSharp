using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem18
    {
        public static int Solve()
        {
            int[] data = { 3, 7, 4, 2, 4, 6, 8, 5, 9, 3};
            BTree tree = new BTree(data);

            return tree.GetMaxPath(tree.GetRoot());
        }
    }
}

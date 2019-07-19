using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class BTree
    {
        Node root = new Node(0);

        // data = array with values of nodes from left to right, up to down
        public BTree(int[] data)
        {
            root = populateTree(root, data, 0);
        }

        public Node populateTree(Node r, int[] data, int i)
        {
            if (i < data.Length)
            {
                r = new Node(data[i]);
                r.SetLeft(populateTree(root.GetLeft(), data, i * 2+1));
                r.SetRight(populateTree(root.GetRight(), data, i * 2 + 2));
            }
            return r;
        }
        public int GetMaxPath(Node n)
        {
            int left = 0;
            int right = 0;
            int max = n.GetData();
            if (n.GetLeft() != null)
            {
                left = GetMaxPath(n.GetLeft());
            }
            if (n.GetRight() != null)
            {
                right = GetMaxPath(n.GetRight());
            }
            if (left > right)
            {
                max += left;
            }
            else
            {
                max += right;
            }
            return max;
        }
        public Node GetRoot()
        {
            return root;
        }
    }
}

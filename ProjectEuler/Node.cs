using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Node
    {
        int data;
        Node left;
        Node right;

        public Node(int d)
        {
            data = d;
            left = null;
            right = null;
        }

        public void SetLeft(Node n)
        {
            left = n;
        }

        public void SetRight(Node n)
        {
            right = n;
        }

        public Node GetLeft()
        {
            return left;
        }

        public Node GetRight()
        {
            return right;
        }

        public int GetData()
        {
            return data;
        }
    }
}

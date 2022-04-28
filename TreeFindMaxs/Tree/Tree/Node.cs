using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{

    public class Node
    {
        public int item;
        public Node left;
        public Node right;
        public Node()
        {

        }

        public Node(int _value)
        {
            item = _value;
        }
    }
}

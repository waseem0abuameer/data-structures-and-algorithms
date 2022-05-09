using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(Node root = null) : base(root)
        { }

        public void Add(int value)
        {
            Node position, temp;
            position = temp = this.Root;
            Node newNode = new Node(value);

            while (temp != null)
            {
                position = temp;
                if (value < position.Value)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < position.Value)
                {
                    position.Left = newNode;
                }
                else
                {
                    position.Right = newNode;
                }
            }
        }

        public bool Contains(Node root, int item)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Value == item)
            {
                return true;
            }
            if (item < root.Value)
            {
                return Contains(root.Left, item);
            }
            else
            {
                return Contains(root.Right, item);
            }
        }
    }
}

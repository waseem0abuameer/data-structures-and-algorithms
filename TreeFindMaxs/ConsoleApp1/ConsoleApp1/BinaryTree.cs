using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<int> list { get; set; }
        public BinaryTree(Node root = null)
        {
            Root = root;
            list = new List<int>();
        }

        public List<int> PreOrder(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            if (Root == root)
            {
                list.Clear();
            }
            list.Add(root.Value);
            if (root.Left != null)
            {
                PreOrder(root.Left);
            }
            if (root.Right != null)
            {
                PreOrder(root.Right);
            }
            return list;
        }

        public List<int> InOrder(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            if (Root == root)
            {
                list.Clear();
            }
            if (root.Left != null)
            {
                InOrder(root.Left);
            }
            list.Add(root.Value);
            if (root.Right != null)
            {
                InOrder(root.Right);
            }
            return list;
        }

        public List<int> PostOrder(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            if (Root == root)
            {
                list.Clear();
            }
            if (root.Left != null)
            {
                PostOrder(root.Left);
            }
            if (root.Right != null)
            {
                PostOrder(root.Right);
            }
            list.Add(root.Value);
            return list;
        }

        public string ToString(List<int> list)
        {
            if (list == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            string toStringList = "";
            foreach (var item in list)
            {
                toStringList += $"{item}, ";
            }
            return toStringList = toStringList.Remove(toStringList.Length - 2);
        }
        public int MaxTree()
        {
            if (InOrder(this.Root) == null)
            {
                Console.WriteLine("Tree is empty!");
             
            }
            return InOrder(this.Root).Max();
        }

    }

    

   
}

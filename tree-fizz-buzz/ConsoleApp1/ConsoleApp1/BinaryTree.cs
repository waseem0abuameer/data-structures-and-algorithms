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
        public List<int> BreadthFirstTree(Node root)
        {
            if (root == null)
            {
                return null;
            }

            List<int> result = new List<int>();
            Queue<Node> breadthQueue = new Queue<Node>();

            breadthQueue.Enqueue(root);
            while (breadthQueue.Count > 0)
            {
                Node front = breadthQueue.Dequeue();
                result.Add(front.Value);

                if (front.Left != null)
                    breadthQueue.Enqueue(front.Left);

                if (front.Right != null)
                    breadthQueue.Enqueue(front.Right);
            }
            return result;
        }
        //    public object[] FizzBuzzTree()
        //    {
        //        return FizzBuzzTree(Root);
        //    }
        //    private object[] FizzBuzzTree(Node root)
        //    {

        //        try
        //        {
        //            if ((int)root.Value % 15 == 0)
        //            {
        //                root.Value = "FizzBuzz";
        //            }
        //            else if ((int)root.Value % 3 == 0)
        //            {
        //                root.Value = "Fizz";
        //            }
        //            else if ((int)root.Value % 5 == 0)
        //            {
        //                root.Value = "Buzz";
        //            }

        //            Tree.Add(root.Value);

        //            if (root.Left != null)
        //            {
        //                FizzBuzzTree(root.Left);
        //            }
        //            if (root.Right != null)
        //            {
        //                FizzBuzzTree(root.Right);
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }

        //        return Tree.ToArray();
        //    }
        //}




    }
}
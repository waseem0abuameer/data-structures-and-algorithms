using System;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinaryTree BT = new BinaryTree();
            BT.Add(1);
            BT.Add(2);
            BT.Add(3);
            BT.Add(4);
            BT.Add(5);
            BT.Add(6);
            BT.Add(7);
            BT.Add(8);          

            Console.Write("pre_Order : ");
            BT.pre_Order();

            Console.WriteLine();
            Console.Write("in_Order : ");
            BT.in_Order();

            Console.WriteLine();
            Console.Write("post_Order : ");
            BT.post_Order();
            Console.WriteLine();

            Console.WriteLine(BT.contains(10));
            Console.WriteLine(BT.contains(8));
            Console.WriteLine("Maximum element is "
                        + BinaryTree.findMax(BT.root));
        }
    }
}

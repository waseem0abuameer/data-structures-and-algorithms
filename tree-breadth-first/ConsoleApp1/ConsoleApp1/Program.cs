using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BinarySearchTree binarySearchTree = new BinarySearchTree(new Node(10));
            //binarySearchTree.Add(2);
            //binarySearchTree.Add(7);
            //binarySearchTree.Add(2);
            //binarySearchTree.Add(6);
            //binarySearchTree.Add(5);
            //binarySearchTree.Add(5);
            //binarySearchTree.Add(11);
            //binarySearchTree.Add(9);
            //binarySearchTree.Add(4);

            //Console.WriteLine(binarySearchTree.ToString(binarySearchTree.InOrder(binarySearchTree.Root)));
            //Console.WriteLine(binarySearchTree.MaxTree());

            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(2);
            tree.Add(7);
            tree.Add(2); 
            tree.Add(6);
            tree.Add(5);
            tree.Add(11); 
            tree.Add(9); 
            tree.Add(4);
            Console.WriteLine(tree.ToString(tree.BreadthFirstTree(tree.Root)));

        }
    }
}

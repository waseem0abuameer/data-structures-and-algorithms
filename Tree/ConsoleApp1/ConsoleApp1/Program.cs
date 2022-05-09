using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree(new Node(10));
            binaryTree.Root.Left = new Node(8);
            binaryTree.Root.Right = new Node(15);
            binaryTree.Root.Left.Left = new Node(5);
            binaryTree.Root.Right.Right = new Node(20);
            Console.WriteLine(binaryTree.ToString(binaryTree.PreOrder(binaryTree.Root)));
            Console.WriteLine(binaryTree.ToString(binaryTree.PostOrder(binaryTree.Root)));
            Console.WriteLine(binaryTree.ToString(binaryTree.InOrder(binaryTree.Root)));
            BinarySearchTree binarySearchTree = new BinarySearchTree(new Node(10));
            binarySearchTree.Add(8);
            binarySearchTree.Add(15);
            binarySearchTree.Add(5);
            binarySearchTree.Add(20);
            Console.WriteLine(binarySearchTree.Contains(binaryTree.Root, 7));
            Console.WriteLine(binarySearchTree.ToString(binarySearchTree.InOrder(binarySearchTree.Root)));
     
        }
    }
}

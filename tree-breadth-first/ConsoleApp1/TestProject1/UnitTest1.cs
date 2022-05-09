using ConsoleApp1;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree(new Node(10));
            binarySearchTree.Add(2);
            binarySearchTree.Add(7);
            binarySearchTree.Add(2);
            binarySearchTree.Add(6);
            int x = binarySearchTree.MaxTree();
            Assert.Equal(x, 10);

        }
        [Fact]
        public void Test2()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree(new Node(10));         
            binarySearchTree.Add(5);
            binarySearchTree.Add(11);
            binarySearchTree.Add(9);
            binarySearchTree.Add(4);
            int x = binarySearchTree.MaxTree();
            Assert.Equal(x, 11);
        }
       
        [Fact]
        public void TreeTest()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(1); tree.Add(2); tree.Add(3); tree.Add(4); tree.Add(5); tree.Add(6);
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(tree.BreadthFirstTree(tree.Root), arr);
        }
        [Fact]
        public void TreeTest1()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(12); tree.Add(13); tree.Add(7); tree.Add(5); tree.Add(1); tree.Add(20);
            int[] arr = { 12, 7, 13, 5, 20, 1 };
            Assert.Equal(tree.BreadthFirstTree(tree.Root), arr);
        }
    }
}

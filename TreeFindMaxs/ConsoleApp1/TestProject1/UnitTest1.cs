using ConsoleApp1;
using System;
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
       
    }
}

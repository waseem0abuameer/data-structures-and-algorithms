using System;
using Xunit;

using  ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void IncludesTest()
        {

            LinkedList MyList = new LinkedList();
            Node first = new Node();
            first.data = 10;
            first.next = null;
            //linking with head node
            MyList.head = first;

            Assert.True(MyList.InorNot(10));
        }
        [Fact]
        public void push_backTest()
        {
            LinkedList MyList = new LinkedList();
            MyList.push_back(10);
            MyList.push_back(20);
            MyList.push_back(30);
            MyList.push_back(40);
            Assert.Equal("[10] -> [20] -> [30] -> [40] -> NULL", MyList.PrintList());
        }
        [Fact]
        public void InsertBeforeTest()
        {
            LinkedList MyList = new LinkedList();
            // If the list is empty, I can't insert before a value so I print
            // that it's empty.
            MyList.push_back(10);
            MyList.AddAfter(10, 20);
            MyList.AddAfter(20, 30);
            // Insert befor middle which is 2.
            MyList.AddBefore(15, 20);
            Assert.Equal("[10] -> [15] -> [20] -> [30] -> NULL", MyList.PrintList());
        }
    
        [Fact]
        public void kthFromEndTest1()
        {
            LinkedList MyList = new LinkedList();
            MyList.push_back(1);
            MyList.push_back(3);
            MyList.push_back(8);
            MyList.push_back(2);
            
            Assert.Equal(3,MyList.kthFromEnd(2));
        }

        [Fact]
        public void kthFromEndTest2()
        {
            LinkedList MyList = new LinkedList();
            MyList.push_back(1);
            

            Assert.Equal(0, MyList.kthFromEnd(2));
        }
        [Fact]
        public void kthFromEndTestNotAPositive()
        {
            LinkedList MyList = new LinkedList();
            MyList.push_back(1);
            MyList.push_back(3);
            MyList.push_back(8);
            MyList.push_back(2);

            Assert.Equal(1, MyList.kthFromEnd(-1));
        }
        [Fact]
        public void kthFromEndSameTest()
        {
            LinkedList MyList = new LinkedList();
            MyList.push_back(1);
            MyList.push_back(3);
            MyList.push_back(8);
            MyList.push_back(2);

            Assert.Equal(1, MyList.kthFromEnd(4));
        }
        [Fact]
        public void kthFromEndGreaterTest()
        {
            LinkedList MyList = new LinkedList();
            MyList.push_back(1);
            MyList.push_back(3);
            MyList.push_back(8);
            MyList.push_back(2);

            Assert.Equal(0, MyList.kthFromEnd(6));
        }
    }
}

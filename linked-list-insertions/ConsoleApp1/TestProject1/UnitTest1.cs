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
        public void InsertAfterLast()
        {
            LinkedList MyList = new LinkedList();
            MyList.push_back(10);
            MyList.push_back(20);
            MyList.push_back(30);
            MyList.AddAfter(25, 25);
            Assert.Equal("[1] -> [2] -> [3] -> [40] -> NULL", MyList.PrintList());
        }

    }
}

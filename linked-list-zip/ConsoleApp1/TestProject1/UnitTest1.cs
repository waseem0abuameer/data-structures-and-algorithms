using System;
using Xunit;

using  ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
     
        [Fact]
        public void ZipTest()
        {
            LinkedList llist1 = new LinkedList();
            LinkedList llist2 = new LinkedList();
            llist1.push(2);
            llist1.push(3);
            llist1.push(1);
            llist2.push(4);
            llist2.push(9);
            llist2.push(5);
            llist1.merge(llist2);
            Assert.Equal("[1] -> [5] -> [3] -> [9] -> [2] -> [4] -> NULL", llist1.PrintList1());
        }
  
    

    }
}

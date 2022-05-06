using System;
using Xunit;
using Code_Challenge_Class_11;
namespace TestClass11
{
    public class UnitTest1
    {
        [Fact]
        public void TestPseudoEnqueue()
        {
            PseudoQueue pseudo = new PseudoQueue();
            pseudo.Enqueue(112);

            Assert.Equal(" 112", pseudo.peek());
        }

        [Fact]
        public void TestPseudoDequeue()
        {
            PseudoQueue pseudo = new PseudoQueue();
            pseudo.Enqueue(112);
            pseudo.Enqueue(211);
            pseudo.Dequeue();


            Assert.Equal(" 211", pseudo.peek());
        }
    }
}

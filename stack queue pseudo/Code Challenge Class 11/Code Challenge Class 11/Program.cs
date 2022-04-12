using System;

namespace Code_Challenge_Class_11
{
    internal class Program
    {
    

        static void Main(string[] args)
        {

            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());




        }
    }
}

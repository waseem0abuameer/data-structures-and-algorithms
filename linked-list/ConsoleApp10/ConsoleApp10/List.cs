using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class List
    {
        Node Head;
        Node Tail;
        public List()
        {
            Head = Tail = null;
        }
        public void AddList(int valu)
        {
            Node item = new Node(valu);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }

        public void Display()
        {
            Node Start = Head;
            if (Start == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.Write("\"");
                while (Start != null)
                {
                    Console.Write($"[{ Start.Data}] ->");
                    Start = Start.Next;
                }
                Console.WriteLine("NULL\"");

            }
        }
        public void INLIST(int X)
        {
            Node Start = Head;
            int c = 0;
            if (Start == null)
            {
                Console.WriteLine("List is Empty");
            }

            else
            {
                while (Start != null)
                {
                    if (X == Start.Data)
                    {
                        Console.Write($"the element found and is : {Start.Data}");
                        c++;
                        break;
                    }
                    else
                        Start = Start.Next;
                }
                if (c == 0)
                    Console.WriteLine("the element not found");

            }
        }
    }
}

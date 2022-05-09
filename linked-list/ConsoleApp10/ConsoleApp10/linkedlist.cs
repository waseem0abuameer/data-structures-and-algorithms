using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
   public class linkedlist
            {
                Node head;
                public linkedlist()
                {
                    head  = null;
                }
            public void push(int new_data)
            {
                
                Node new_node = new Node(new_data);

                new_node.next = head;

                head = new_node;
            }
          public bool Includes(int data)
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        return true;
                    }
                    temp = temp.next;
                }
                return false;
            }

            public void tostring()
                {
                    Node Start = head;
                    if (Start == null)
                    {
                        Console.WriteLine("List is Empty");
                    }
                    else
                    {
                        Console.Write("\"");
                        while (Start != null)
                        {
                            Console.Write($"[{ Start.data}] ->");
                            Start = Start.next;
                        }
                        Console.WriteLine("NULL\"");

                    }
                }
               
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp10
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
           linkedlist l = new linkedlist();
                    l.push(5);
                    l.push(6);
                    l.push(10);

                    l.push(10);

                    l.push(10);
                    l.Display();
                 if (l.Includes(10))
                    Console.WriteLine("FOUND");
                else
                    Console.WriteLine("NOT FOUND");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_Class_11
{
    public class PseudoQueue
    {
        public Stack One = new Stack();
        public Stack Two = new Stack();

        public void Enqueue(int value)
        {
            if (One.Top == null)
            {
                One.push(value);
            }
            else
            {
                while (One.Top != null)
                {
                    Two.push(One.pop());
                }
                One.push(value);
                while (Two.Top != null)
                {
                    One.push(Two.pop());
                }
            }
            Console.WriteLine(One.Print());

        }

        public void Dequeue()
        {
            if (One.Top == null)
            {
                throw new Exception("Stack One Is Empty !");
            }
            else
            {
                One.pop();
            }

        }
        public string peek()
        {

            if (One.Top == null)
            {
                throw new Exception("Stack One Is Empty !");
            }
            else
            {

                return $" {One.Top.Value}";
            }
        }
    }
}


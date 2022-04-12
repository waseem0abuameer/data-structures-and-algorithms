using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_Class_11
{
    public class PseudoQueue
    {
            Stack stack1 = new Stack();

            Stack stack2 = new Stack();

        public void Enqueue(int value)
        {
            while( stack1.Count > 0)
            {
                stack2.Push(stack1.Peek());
            }
            stack1.Push(value);
        }

        public int Dequeue()
        {
            int value = (int)stack1.Peek();
            return value;
        }
       
      
      
    }
    }


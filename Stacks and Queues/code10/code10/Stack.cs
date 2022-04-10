using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code10
{
    public class Stack
    {
        Node Top;
        public Stack()
        {
            Top = null;
        }
        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (Top == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = Top;
            }
           
            Top = newNode;
        }

        public void Pop()
        {
            if (Top == null)
                throw new Exception("Empty Stack!");

            Top = Top.Next;
        }

        public int Peek()
        {
            if (Top == null)
                throw new Exception("Empty Stack!");

            return Top.Value;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }

        
    }
}

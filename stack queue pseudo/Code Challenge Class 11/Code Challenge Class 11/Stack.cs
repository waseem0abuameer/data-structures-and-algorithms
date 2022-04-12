using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_Class_11
{
    public class Stack
    { public int Count=0;
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
            Count++;
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
        public void DisplayStack(Stack s)
        {

            // Create another stack
            Stack s1 = new Stack();

            // Until stack is empty
            while (s.IsEmpty() != true)
            {
                s1.Push(s.Peek());

                // Print the element
                Console.Write(s1.Peek() + " ");
                s.Pop();
            }
        }

    }
}

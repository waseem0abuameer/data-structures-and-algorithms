using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code10
{
    public class Queue
    {
        Node Front;
        Node Rear;
        public Queue()
        {
            Front = Rear = null;
        }

        public void Enqeue(int value)
        {
            Node newNode = new Node(value);

            if (Rear == null && Front == null)
            {
                Front = Rear = newNode;
            }
            else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }
        }

        public void Dequeue()
        {
            if (Front == null)
                throw new Exception("The Queue is empty!");

            Front = Front.Next;
        }

        public int Peek()
        {
            if (Rear == null)
                throw new Exception("The Queue is empty!");

            return Front.Value;
        }

        public bool IsEmpty()
        {
            return Front == null;
        }

        

    }
}


using System;

namespace ConsoleApp1
{
    class Node
    {
        public int data;
        public Node next;
    }
    class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void PrintList()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.Write("The list contains: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
        ////////////
        ///
        public void push_back(int newElement)
        {

            //1. allocate node
            Node newNode = new Node();

            //2. assign data element
            newNode.data = newElement;

            //3. assign null to the next of new node
            newNode.next = null;

            //4. Check the Linked List is empty or not,
            //   if empty make the new node as head
            if (head == null)
            {
                head = newNode;
            }
            else
            {

                //5. Else, traverse to the last node
                Node temp = new Node();
                temp = head;
                while (temp.next != null)
                    temp = temp.next;

                //6. Change the next of last node to new node
                temp.next = newNode;
            }
        }
        /// <summary>
        /// 

        public void push_at(int newElement, int position)
        {

            //1. allocate node to new element
            Node newNode = new Node();
            newNode.data = newElement;
            newNode.next = null;

            //2. check if the position is > 0
            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1)
            {

                //3. if the position is 1, make next of the
                //   new node as head and new node as head
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = new Node();
                temp = head;

                while (temp != null)
                {
                    if (temp.data == position)
                        break;
                    else
                        temp = temp.next;
                    
                }

                Console.WriteLine(temp.data);
                if (temp.data == position) { 
                    newNode.next=temp.next;
                temp.next = newNode;
                }
                else { }

            }


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList MyList = new LinkedList();
            //Add first node.
            Node first = new Node();
            first.data = 10;
            first.next = null;
            //linking with head node
            MyList.head = first;
            //Add second node.
            Node second = new Node();
            second.data = 20;
            second.next = null;
            //linking with first node
            first.next = second;

            //Add third node.
            Node third = new Node();
            third.data = 30;
            third.next = null;
            //linking with second node
            second.next = third;
            MyList.push_back(40);
            MyList.push_at(15,200);
            MyList.PrintList();
        }
        //print the content of list
         

    }
}

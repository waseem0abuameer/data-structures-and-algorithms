using System;
namespace ConsoleApp1
{
    public class Node
    {
        public int data;
        public Node next;
    }
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public string PrintList()
        {
            string outPut = "";
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.Write("The list contains: ");
                while (temp != null)
                {
                    outPut += $"[{temp.data}] -> ";
                    temp = temp.next;
                }
                outPut += "NULL";

            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
            return outPut;
        }
        public bool InorNot(int data)
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


        public void AddBefore(int position, int newElement)
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty!");
            }
            else if (InorNot(position))
            {
                Node temp = head;
                Node newNode = new Node();
                newNode.data = newElement;
                newNode.next = null; ;


                if (temp.next == null)
                {
                    newNode.next = temp;
                    head = newNode;
                }

                else
                {
                    while (temp.next.data != position)
                    {
                        temp = temp.next;
                    }

                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
            else
            {
                Console.WriteLine(" ===>position not Found===No change, method exception !");
            }
        }



        public void AddAfter(int position, int newElement)
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty!");
            }
            else if (InorNot(position))
            {
                Node temp = head;
                while (temp.data != position)
                {
                    temp = temp.next;
                }
                Node newNode = new Node();
                newNode.data = newElement;
                newNode.next = null; ;
                if (temp.next != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    temp.next = newNode;
                }
            }
            else
            {
                Console.WriteLine(" ===>position not Found===No change, method exception !");
            }
        }

        public int kthFromEnd(int K)
        {
            

            
            int Counter1 = 0;
            int Counter2 = 0;
            Node Curent = head;
            int val = 1;

            while (Curent != null)
            {
                Counter1++;
                Curent = Curent.next;
            }


            Curent = head;

            while (Curent != null)
            {
                if (K > Counter1)
                {
                    Console.WriteLine("Exception");
                    return 0;
                }

                Counter2++;
                if (Counter2 == (Counter1 - K))
                {
                    val = Curent.data;
                    break;
                }
                else
                {
                    Curent = Curent.next;
                }
            }

            return val;
        }


    }
        internal class Program
        {
            static void Main(string[] args)
            {

                LinkedList MyList = new LinkedList();
                Console.WriteLine("Append");
                MyList.push_back(1);
                MyList.push_back(3);
                MyList.push_back(8);
                MyList.push_back(2);
                Console.WriteLine(MyList.PrintList());
                Console.WriteLine("======KH=======");
            Console.WriteLine(MyList.kthFromEnd(0));
            Console.WriteLine(MyList.kthFromEnd(2));
            Console.WriteLine(MyList.kthFromEnd(6));



        }
            //print the content of list


        }
    }

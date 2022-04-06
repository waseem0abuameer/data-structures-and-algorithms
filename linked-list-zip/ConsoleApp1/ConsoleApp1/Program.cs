using System;
namespace ConsoleApp1
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
        public Node()
        {
         
        }
    }
   
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }

        
        public void push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }
        public void merge(LinkedList NewZipLinkedList)
        {
            Node curr1 = head, curr2 = NewZipLinkedList.head;
            Node next1, next2;

            // While there are available positions in p;
            while (curr1 != null && curr2 != null)
            {

                // Save next pointers
                next1 = curr1.next;
                next2 = curr2.next;

                // make q_curr as next of p_curr
                curr2.next = next1; // change next pointer of q_curr
                curr1.next = curr2; // change next pointer of p_curr

                // update current pointers for next iteration
                curr1 = next1;
                curr2 = next2;
            }
            NewZipLinkedList.head = curr2;
        }
        public void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public string PrintList1()
        {
            string outPut = "";
            Node temp = head;
           
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


    }
        internal class Program
        {
            static void Main(string[] args)
            {

            LinkedList llist1 = new LinkedList();
            LinkedList llist2 = new LinkedList();
            llist1.push(2);
            llist1.push(3);
            llist1.push(1);

            Console.WriteLine("First Linked List:");
            llist1.printList();

            
            llist2.push(4);
            llist2.push(9);
            llist2.push(5);

            Console.WriteLine("Second Linked List:");
            llist2.printList();
            llist1.merge(llist2);

         
            

            Console.WriteLine(llist1.PrintList1());



        }
            //print the content of list


        }
    }

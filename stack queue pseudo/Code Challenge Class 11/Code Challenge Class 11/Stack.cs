﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_Class_11
{
    public class Stack
    {
        public Node Top { get; set; }
        int count = 0;
        public Stack()
        {

        }
        public Stack(Node node)
        {
            Top = node;
        }

        public void push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
            count++;
        }
        public int Size()
        {
            return count;
        }
        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            else
                return false;
        }
        public int pop()
        {
            if (Top == null)
            {
                throw new Exception("Stack is empty");
                return -1;
            }
            else
            {
                Node temp = Top;
                Top = Top.Next;
                temp.Next = null;
                count--;
                
                return temp.Value;
            }
        }
        public string peek()
        {

            if (Top == null)
            {
                throw new Exception("Stack is empty");
            }
            else
            {

                return $"peek is {Top.Value}";
            }
        }
        public string Print()
        {
            string Format = "";

            if (Top == null)
                return "Stack is Empty!";

            else
            {
                Node current = Top;
                while (current != null)
                {
                    Format += "[" + current.Value + "] -> ";
                    current = current.Next;
                }
            }

            Format += "NULL";

            return Format;
        }
    }
}

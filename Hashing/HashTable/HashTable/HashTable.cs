using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable
    {
        int storesi = 500;
        private Node[] store { get; set; }

        public HashTable()
        {
            store = new Node[storesi];
        }


        public void Set(string key, string value)
        {
            int index = Hash(key);
            Node newNode = new Node(key, value);

            if (store[index] == null)
            {
                store[index] = newNode;
            }
            else
            {
                Node curnt = store[index];
                while (curnt.Next != null)
                {
                    curnt = curnt.Next;
                }
                curnt.Next = new Node(key, value);
            }
        }


        public Node Get(string key)
        {
            int index = Hash(key);
            Node curnt = store[index];

            while (curnt != null)
            {
                if (curnt.Key == key)
                {
                    return curnt;
                }
                curnt = curnt.Next;
            }

            return null;
        }


        public bool Contains(string key)
        {
            int index = Hash(key);
            Node curnt = store[index];

            while (curnt != null)
            {
                if (curnt.Key == key)
                {
                    return true;
                }
                curnt = curnt.Next;
            }

            return false;
        }

        public int Hash(string key)
        {
            int hash = 0;

            foreach (int Data in key)
            {
                hash += Data;
            }

            return hash * 599 % 500;
        }
        public int conts1()
        {
            return conts(store);
        }
        public int conts(Node[] key)
        {
            int cont=0;
            for (int i = 0; i < key.Length; i++)
                cont++;
            return cont ;
        }
    }
}

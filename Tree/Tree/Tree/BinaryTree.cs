using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {

        }
        public BinaryTree(Node node)
        {

        }
        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                AddTo(root, value);
            }
        }
        private void AddTo(Node node, int value)
        {
            if (value < node.item)
            {
                if (node.left == null)
                {
                    node.left = new Node(value);
                }
                else
                {
                    AddTo(node.left, value);
                }
            }
            else
            {
                if (node.right == null)
                {
                    node.right = new Node(value);
                }
                else
                {
                    AddTo(node.right, value);
                }
            }

        }
        public void pre_Order()
        { 
            //to Travers in tree(BTT) in Program
            try {pre_Order(root);  }
          
             catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        private void pre_Order(Node node)
        {
            //to Travers in tree(BTT) in BinaryTree
            if (node != null)
            {
                Console.Write(node.item + ",");
                pre_Order(node.left);
                pre_Order(node.right);
            }

        }
        public void in_Order()
        {
            try { in_Order(root);   }

            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
                     
           
        }
        private void in_Order(Node node)
        {
            if (node != null)
            {
                in_Order(node.left);
                Console.Write(node.item + ",");
                in_Order(node.right);
            }
        }
        public void post_Order()
        {
            try {  post_Order(root);}

            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

           
           
        }
        private void post_Order(Node node)
        {
            if (node != null)
            {
                post_Order(node.left);
                post_Order(node.right);
                Console.Write( node.item+",");
            }
        }
        public bool contains(int value)
        {
            try
            {
                Node current = root;
                while (current != null)
                {
                    if (value > current.item)
                    {
                        current = current.right;
                    }
                    else if (value < current.item)
                    {
                        current = current.left;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return false;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    internal class Queues
    {
        int total = 0;
        public class Node
        {
            public Node value;
            public object next;
        }
        //sets root node to private
        private Node root;

        //this gets the private root element and sets it at the first node in the linkedList
        public Node first
        {
            get { return root; }
        }

        public Node last
        {

            get
            {
                Node currentNode = root;
                if (currentNode == null)
                {
                    return null;
                }
                while (currentNode != null)
                {
                    currentNode = currentNode.next;
                }
                return currentNode;

            }
        }
        //this checks if the linkedlist is empty and returns the boolean
        public bool isEmpty
        {
            get
            {
                if (root == null)
                {
                    return true;
                }
                return false;
            }
        }



        public void Enqueue(object data)
        {
            Node node = new Node { value = data};
            if (root == null)
            {
                root = node;
            }
            else
            {
                last.next = node;
            }
        }
        //this checks the size of the linkedList and returns an integer value
        public int size
        {

            get
            {
                Node currentNode = root;

                if (currentNode == null)
                {
                    return total;
                }
                if (currentNode != null)
                {
                    return 1;
                    while (currentNode.next != null)
                    {
                        total += 1;

                        return total;
                    }

                }
                return total;

            }
        }

        public Node Dequeue(Node node)
        {

            if (root == node)
            {
                root = node.next;
                root = null;
                return node.next;
            }
            else
            {
                Node currentNode = root;
                while (currentNode.next != null)
                {
                    if (currentNode.next == node)
                    {
                        currentNode.next = node.next;
                        node.next = null;
                        break;
                    }
                    currentNode = currentNode.next;
                }
                return node.next;
            }
        }



    }
}



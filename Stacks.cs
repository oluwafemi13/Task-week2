using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    internal class Stacks
    {
        int total = 0;
        public class Node
        {
            public Node next;
            public object value;

        }
        private Node root;

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
        //is empty in stacks
        //check if the stack is empty......LIFO
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

        //this function is to append or push in a stack using a linked list methodology
        public void append(object data)
        {
            Node node = new Node { value = data };
            if (root == null)
            {
                root = node;
            }
            else
            {
                last.next = node;
            }

        }

        //to remove a node or element in a stack
        public Node remove(Node node)
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
        //this method returns the last item in the linked list
        public Node peek
        {
            get { return last; }

        }
        //this method returns the last element or node in the linked list
        public int size
        {
            
            get { 
                Node currentNode = root;

                if(currentNode == null)
                {
                    return total;
                }
                if(currentNode != null)
                {
                    return 1;
                    while (currentNode.next != null)
                    {
                        total +=  1;

                        return total;
                }
                    
                }
                return total;

            }

        }
    }

        
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    internal class LinkedList
    {
        public static void Main(string[] agrs)
        {
            
        }

        public class Node
        {
            public Node next;
            public object data;
        }

        //create an object of the root node and make it accessible to only the first node
        private Node root;

        public Node first
        {
            get { return root; }
        }

        public Node last
        {
            get
            {
                //we have extablished the current node as the root and want to get the last node by
                //looping through checking if the next node is not null.. if the next node is null,and the  
                //current node isnt, signifies the last node
                Node currentNode = root;
                if (currentNode == null)
                {
                    return null;
                }
                //this is to check if the current node is null, if it isnt,
                //move to the next node and continue check
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                return currentNode;

            }

        }
        //this function is to add to a linked list
        public void Append(object value)
        {
            Node node = new Node { data = value };

            if (root == null)
            {
                root = node;
            }
            else
            {
                last.next = node;
            }
        }
        //this method is to remove from the linked list
        public void delete(Node node)
        {
            if(root == node)
            {
                root = node.next;
                node.next= null;
            }else
            {
                Node current = root;
                while(current.next !=null)
                {
                    if(current.next == node)
                    {
                        current.next = node.next;
                        node.next = null;
                        break;
                    }
                    current = current.next;
                }
            }

        }
        //this check method is used to check for a given data in every node
        public bool check(object value)
        {
            bool check = false;
            Node node = new Node { data = value};

            Node currentNode = root;
            if(currentNode == value) { return true; }
            else
            {
                return false;
                currentNode.next = node.next;
            }
            
           while(currentNode.next != null)
            {
                if(currentNode.data == value)
                {
                    return true;
                }
                else
                {
                    currentNode.next = currentNode.next.next;
                }
            }
            return check;
            

        }
        
    }
}

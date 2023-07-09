using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    internal class LinkedList
    {
        private Node head;
       public LinkedList() 
        {
            head = null;
        }

        public void insert(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
        }
        public void display()
        {
            Node node = head;   
            while(node != null)
            {
                Console.Write(node.data + " "); //prints them into a raw
                //Console.WriteLine(node.data);   //prints them into a column
                node = node.next;
            }
        }
        public void remove(int data)
        {

        }

    }
}

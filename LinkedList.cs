using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            //head is null
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return; // to avoid the exception when it occurs.
            }
            //head is not null
            else
            {
                // delete head
                if (head.data == data)
                {
                    head = head.next;
                }
                else
                {
                    Node currentNode = head;
                    Node prevNode = null;
                    while(currentNode != null && currentNode.data!= data)
                    {
                        prevNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    if(currentNode == null)
                    {
                        var a = $"{data} is not Found in the linked list";
                        Console.WriteLine($"({a})");
                        return; // to avoid the exception when it occurs.
                    }
                    prevNode.next = currentNode.next;
                }
            }
        }
        public void addItemAnywhere(int data, int position)
        {
            Node newNode = new Node(data);
            int currentPosition;

            if (position <= 0)
            {
                // Add at the beginning of the list
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                Node prevNode = null;
                currentPosition = 0;

                while (currentNode != null && currentPosition < position)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.next;
                    currentPosition++;
                }

                // Insert the new node
                prevNode = currentNode;
                currentNode = currentNode.next;
            }
        }
    }
}

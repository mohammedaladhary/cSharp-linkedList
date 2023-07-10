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
        private Node Head;
        public LinkedList()
        {
            Head = null;
        }

        public void insert(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }
        public void display()
        {
            Node node = Head;
            while (node != null)
            {
                Console.Write(node.data + " "); //prints them into a raw
                //Console.WriteLine(node.data);   //prints them into a column
                node = node.Next;
            }
        }
        public void remove(int data)
        {
            //Head is null
            if (Head == null)
            {
                Console.WriteLine("Linked List is empty");
                return; // to avoid the exception when it occurs.
            }
            //Head is not null
            else
            {
                // delete Head
                if (Head.data == data)
                {
                    Head = Head.Next;
                }
                else
                {
                    Node currentNode = Head;
                    Node prevNode = null;
                    while (currentNode != null && currentNode.data != data)
                    {
                        prevNode = currentNode;
                        currentNode = currentNode.Next;
                    }
                    if (currentNode == null)
                    {
                        var a = $"{data} is not Found in the linked list";
                        Console.WriteLine($"({a})");
                        return; // to avoid the exception when it occurs.
                    }
                    prevNode.Next = currentNode.Next;
                }
            }
        }
        public void addNodeAnyPoint(int data, int position)
        {
            Node newNode = new Node(data);
            if (position == 0)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node current = Head;
                Node previous = null;
                int count = 0;

                while (current != null && count < position)
                {
                    previous = current;
                    current = current.Next;
                    count++;
                }

                if (current == null)
                {
                    // Reached the end of the list
                    previous.Next = newNode;
                }
                else
                {
                    newNode.Next = current;
                    previous.Next = newNode;
                }
            }
        }
        public void dataGetPosition(int data)
        {
            Node current = Head;
            int position = 0;

            while (current != null)
            {
                if (current.data == data)
                {
                    Console.WriteLine("Data found at position: " + position);
                    return;
                }

                current = current.Next;
                position++;
            }
        }
        public void positionGetData(int position)
        {
            Node current = Head;
            int data = 0;
            while (current != null)
            {
                if (current.data == position)
                {
                    Console.WriteLine("Data result for the position entered : " + data);
                    return;
                }

                current = current.Next;
                position++;
            }
        }
    }
}

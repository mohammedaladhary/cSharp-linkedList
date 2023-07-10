namespace linkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedList list = new LinkedList();
            list.insert(10);
            list.insert(20);
            list.insert(30);
            list.insert(40);
            list.addNodeAnyPoint(5, 2);

            Console.WriteLine("Original list:");
            list.display();
            Console.WriteLine();
            list.dataGetPosition(10);
            list.positionGetData(3);

            list.remove(50);
            Console.WriteLine();
            Console.WriteLine("Updated list:");
            list.display();

            //Simple Linked list from .net library
            //LinkedList<int> list2 = new LinkedList<int>();
            //LinkedListNode<int> node1 = new LinkedListNode<int>(10);
            //LinkedListNode<int> node2 = new LinkedListNode<int>(20);
            //LinkedListNode<int> node3 = new LinkedListNode<int>(30);
            //LinkedListNode<int> node4 = new LinkedListNode<int>(40);
            //list2.AddFirst(node1);
            //list2.AddLast(node2);
            //list2.AddAfter(node2, node3);
            //list2.AddBefore(node1, node4);

            //foreach (int i in list2)
            //{
            //    Console.WriteLine(i);
            //}



        }
    }
}
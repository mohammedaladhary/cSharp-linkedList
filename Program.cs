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
            Console.WriteLine();
            Console.WriteLine("Original list:");
            list.display();

        }
    }
}
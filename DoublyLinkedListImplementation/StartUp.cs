using System;

namespace DoublyLinkedListImplementation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddLast(5);
            list.AddLast(4);
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(1);

            list.RemoveLast();
            list.RemoveLast();

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}

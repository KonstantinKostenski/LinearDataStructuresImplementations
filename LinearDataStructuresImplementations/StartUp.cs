using System;

namespace LinearDataStructuresImplementations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Testing area for the collections.
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            ArrayStack<int> stack = new ArrayStack<int>();
            LinkedStack<int> linkedStack = new LinkedStack<int>();

            linkedStack.Push(1);
            linkedStack.Push(2);
            linkedStack.Push(3);
            linkedStack.Push(4);
            linkedStack.Push(5);

            linkedStack.Pop();
            linkedStack.Pop();
            linkedStack.Pop();


            foreach (var number in linkedStack)
            {
                Console.WriteLine(number);
            }

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            //foreach (var number in stack)
            //{
            //    Console.WriteLine(number);
            //}

            list.AddLast(5);
            list.AddLast(4);
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(1);

            list.RemoveLast();
            list.RemoveLast();

            //foreach (var number in list)
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}

using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new();
            
            linkedList.AddEnd(1);
            linkedList.AddEnd(2);
            linkedList.AddEnd(3);
            linkedList.AddEnd(5);
            linkedList.AddEnd(6);
            linkedList.AddEnd(7);
            linkedList.AddEnd(8);
            linkedList.AddEnd(9);
            
            linkedList.AddStart(0);
            
            linkedList.Print();

            if (linkedList.Search(5))
            {
                Console.WriteLine("found!");
            }

        }

    }
}
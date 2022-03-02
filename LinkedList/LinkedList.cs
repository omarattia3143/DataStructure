using System;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public LinkedList()
        {
            Head = Tail = null;
        }

        public void Print()
        {
            PrintInternal(Head);
        }

        private void PrintInternal(Node node)
        {
            if (Head is null)
            {
                Console.WriteLine("No Elements in the LinkedList");
                return;
            }

            if (node is null)
                return;


            Console.WriteLine(node.Value);
            PrintInternal(node.Next);
        }


        public void AddEnd(int value)
        {
            Node newNode = new(value);

            if (Head is null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public void AddStart(int value)
        {
            if (Head is null)
            {
                AddEnd(value);
            }

            Node newNode = new(value);

            newNode.Next = Head;
            Head = newNode;
        }

        public bool Search(int value)
        {
            var node = Head;
            if (node is null)
            {
                Console.WriteLine("No Elements in the LinkedList");
                return false;
            }

            while (node != null)
            {
                if (node.Value == value)
                {
                    return true;
                }
                else
                {
                    node = node.Next;
                }
            }

            return false;
        }
    }
}
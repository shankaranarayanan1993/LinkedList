using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node FirstNode = new Node { Value = 1 };
            //Node MiddleNode = new Node { Value = 2 };
            //Node LastNode = new Node { Value = 3 };

            //FirstNode.Next = MiddleNode;
            //MiddleNode.Next = LastNode;

            //printList(FirstNode);

            LinkedList lnklist = new LinkedList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtLast(12);
            lnklist.AddAtLast("John");
            lnklist.AddAtLast("Peter");
            lnklist.AddAtLast(34);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtStart(55);
            lnklist.AddAtStart("John");
            lnklist.AddAtStart("Peter");
            lnklist.PrintAllNodes();
            Console.WriteLine();
            lnklist.RemoveByIndex(2);
            lnklist.RemoveFromStart();
            lnklist.PrintAllNodes();
         

            Console.ReadKey();

        }
        private static void printList(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}   

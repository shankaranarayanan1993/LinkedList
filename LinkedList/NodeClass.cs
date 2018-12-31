using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    // Step 1: Here is the node class which has 2 properties: 
    // One property is 'Next', which will have reference of next node and another is 'Value', which will have data in this node.
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }
    }
    // Now implement linked list class as follows:  
    //'head' will have head node. 'current' will have latest node, i.e., tail node and 'Count' will return total number of nodes in linked list.
    public class LinkedList
    {
        public Node head;
        public Node current;
        public int Count;
        public LinkedList()
        {
            head = new Node();
            //Here current and head points to same memory , so change in any propertis of current  will change head
            current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            // Here whenever there is a change the current , head will get automatically changed as it is a reference of it
            current.Next = newNode; // Now Head.Next will have data value (ex: 12)
            current = newNode; // Here we preserve the head' added value pointer to current
            Count++;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;//new node will have reference of head's next reference
            head.Next = newNode;//and now head will refer to new node
            Count++;
        }

        public void RemoveFromStart()
        {
            while (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            //else
            //{
            //    Console.WriteLine("No element exist in this linked list.");
            //}
        }

        public void RemoveByIndex(int index)
        {
            int count = 0;
            Node current = head;
            Node previous = current;
            while (count <= index)
            {
                if (count == index)
                {
                    previous.Next = current.Next;
                    current = null;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
                count++;
            }
        }

        /// <summary>
        /// Traverse from head and print all nodes value
        /// </summary>

        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
    }
}

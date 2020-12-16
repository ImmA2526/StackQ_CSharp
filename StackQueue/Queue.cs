using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public class Queue
    {
        /// <summary>
        /// UC3- Create Que 
        /// </summary>
        internal Node head;
        internal void EndedQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("\n{0} Inserted in Q", node.data);
            }
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\n Que is Empty");
                return;
            }
            Console.WriteLine("Data is : ");
            while (temp != null)
            {
                Console.Write(temp.data+ " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
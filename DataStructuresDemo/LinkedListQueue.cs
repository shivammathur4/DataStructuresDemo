using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo
{
    public class LinkedListQueue
    {
        Node head = null;
       
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine(head.data + " removed from Queue");
                head = head.next;
            }
        }

        internal void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.Write(temp.data + "\n");
            }
        }
    }
}

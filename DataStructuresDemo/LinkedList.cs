using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void AddBefore(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = head;
            }
            head = node;
            Console.WriteLine("{0} added before the head on the list", node.data);
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        Console.WriteLine("{0} added successfully at {1} position", node.data, position + 1);
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        public void DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("No nodes are there in the linked list");
                return;
            }
            this.head = head.next;
        }
        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }
        public void InsertAfterValue(int existingValue, int valueToBeInserted)
        {
            Node temp = Search(existingValue);
            Node node = new Node(valueToBeInserted);
            node.next = temp.next;
            temp.next = node;
            return;
        }
        public void DeleteWithValue(int data)
        {
            Node delete = Search(data);
            Node temp = this.head;
            if (delete == null)
            {
                Console.WriteLine("Value doesn't exist in the list");
                return;
            }
            else
            {
                while (temp.next != delete)
                {
                    temp = temp.next;
                }
                temp.next = delete.next;
                Console.WriteLine(data + " deleted successfully");
                return;
            }
        }
        public int SizeOfList()
        {
            int size = 1;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            while (temp.next != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
        public void AddWithSorting(int data)
        {
            LinkedListNode<int> node = new LinkedListNode<int>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                if (this.head.data > data)
                {
                    node.next = this.head;
                    this.head = node;
                }
                else
                {
                    LinkedListNode<int> temp = this.head;
                    while (temp.next != null && temp.Next.data < data)
                    {
                        temp = temp.next;
                    }
                    node.next = temp.next;
                    temp.next = node;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, Welcome to Linked List!");
            //LinkedList list = new LinkedList();

            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.Display();
            //Console.ReadKey();

            //LinkedListStack list = new LinkedListStack();
            //list.Push(70);
            //list.Push(30);
            //list.Push(56);
            //list.IsEmpty();
            //list.Display();
            //Console.ReadKey();

            
            LinkedListQueue list = new LinkedListQueue();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Dequeue();
            list.Display();
            Console.ReadKey();  





        }
    }
}

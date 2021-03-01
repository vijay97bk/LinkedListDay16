using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDay16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList list = new LinkedList();
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);

            list.Display();

            
        }
    }
}

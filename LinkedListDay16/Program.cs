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
            //UC1
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            list.Display();
            //UC2
            list.InsertFront(70);
            list.InsertFront(30);
            list.InsertFront(56);
            list.Display();
            //UC3
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            //insert at middle UC4
            LinkedList listAtMiddle = new LinkedList();
            listAtMiddle.InsertLast(56);
            listAtMiddle.InsertLast(70);
            listAtMiddle.AddNodeAtMiddle(30, 56);
            listAtMiddle.Display();
            //UC5 delete node at first
            listAtMiddle.Display();
            listAtMiddle.DeleteNodeAtFirst();
            listAtMiddle.Display();
        }
           
    }
}

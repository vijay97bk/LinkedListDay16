﻿using System;
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
        }
           
    }
}

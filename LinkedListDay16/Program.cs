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
            //UC6 Delet Last node
            list.Display();
            list.DeleteLastNode();
            list.Display();

            //Searchin node UC7
            LinkedList searchList = new LinkedList();
            Node node56 = new Node(56);
            Node node30 = new Node(30);
            Node node70 = new Node(70);
            node56.next = node30;
            node30.next = node70;
            searchList.head = node56;
            searchList.Display();
            if (searchList.Search(30))
                Console.WriteLine("Node found");
            else
                Console.WriteLine("Node not found");

            //Add node after a node UC8
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            list.AddNodeAtMiddle(40, 30);
            list.Display();

            //Delete perticular node
            list.Display();
            list.DeleteNodeWithValue(40);
            list.Display();

            Sorting sort = new Sorting();
            sort.AddNode(56);
            sort.AddNode(30);
            sort.AddNode(40);
            sort.AddNode(70);
            sort.Display();
        }
           
    }
}

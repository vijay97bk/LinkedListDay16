using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDay16
{
    class LinkedList
    {
        public Node head ;
        public Node lastNode;
        /// <summary>
        /// Inserts at the last last. UC1
        /// </summary>
        /// <param name="newData">The new data.</param>
        /// <returns></returns>
        public Node InsertLast(int newData)
        {
            Node newNode = new Node(newData);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;// changing the next pointer 
            }
            Console.WriteLine("Inserted Into list " + newNode.data);
            return newNode;
        }
        public Node GetLastNode()
        {
            Node last = this.head;
            while (last.next != null)
            {
                last = last.next;
            }
            return last;
        }
        public Node Display()
        {
            Console.WriteLine("Displaying nodes");
            Node listdata = this.head;
            if (listdata == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while (listdata != null)
                {
                    Console.WriteLine("Nodes in Linked List: " + listdata.data);
                    listdata = listdata.next;
                }

            }
            return listdata;
        }
        public void InsertFront(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("Inserted at front:" + newData);
        }
        public void Append(int newData)
        {
            InsertLast(newData);
        }
    }
}

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
                lastNode.next = newNode;
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
        /// <summary>
        /// Adds the node after node. UC4
        /// </summary>
        /// <param name="newData">The new data.</param>
        /// <param name="addAfterNode">The add after node.</param>
        public void AddNodeAtMiddle(int newData, int addAfterNode)
        {
            Node newNode = new Node(newData);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.data != addAfterNode)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;

            }
            Console.WriteLine("Added in between Node: " + newData);
        }
        /// <summary>
        /// Deletes the node at first. UC5
        /// </summary>
        public void DeleteNodeAtFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }

            Node temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }
        /// <summary>
        /// Deletes the node at last. UC6
        /// </summary>
        public void DeleteLastNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Nothing To Delete");
                return;
            }
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        /// <summary>
        /// Searches the specified value. UC7
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public bool Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return true;
        }
        /// <summary>
        /// Deletes the node with value.UC9
        /// </summary>
        /// <param name="value">The value.</param>
        public void DeleteNodeWithValue(int value)
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            Node prev = this.head;
            Node FindValue = this.head;
            while (FindValue.data != value)
            {
                if (FindValue == null)
                {
                    break;
                }
                FindValue = FindValue.next;
            }
            while (prev.next.data != value)
            {
                if (prev == null)
                {
                    break;
                }
                prev = prev.next;
            }
            prev.next = FindValue.next;

        }
    }
}

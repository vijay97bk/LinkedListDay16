using System;

namespace LinkedListDay16
{
    internal class Sorting
    {
            public Node head;
        /// <summary>
        /// Initializes a new instance of the <see cref="Sorting"/> class.
        /// </summary>
        public Sorting()
            {
                head = null;//initially node is null
            }

            private void AddNodeAtStart(int value)
            {
                Node newNode = new Node(value);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.next = head;
                    head = newNode;
                }
            }
            public void AddNodeAtEnd(int value)
            {
                Node newNode = new Node(value);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;

                }
            }
            public void AddNode(int value)
            {
                Node newNode = new Node(value);
                if (head == null)
                {
                    head = newNode; //creating new node if head is null
                    return;
                }
                if (value < head.data)
                {
                    AddNodeAtStart(value); //if data 
                    return;
                }
                Node temp = head;
                while (temp.next.data < value)
                {
                    temp = temp.next;
                    if (temp.next == null)
                    {
                        break;
                    }
                }
                if (temp.next == null)
                {
                    AddNodeAtEnd(value);
                }
                else
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }

            }
            public void AddNodeAfterNode(int nodeValue, int addAfterThisValue)
            {
                Node newNode = new Node(nodeValue);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node temp = head;
                    while (temp.data != addAfterThisValue)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;

                }
                Console.WriteLine($"Added {nodeValue} at in between");
            }

            public void Display()
            {
                if (head == null)
                {
                    Console.WriteLine("Nothing to display");
                    return;
                }

                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    if (temp.next != null)
                    {
                        Console.Write("->");
                    }
                    temp = temp.next;
                }
                Console.WriteLine();
            }
    }
}
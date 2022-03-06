using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkListOperation
    {
        Node head = null;
        public void append(int value)
        {
            Node temp = head;
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;
            if (head != null)
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            else
            {
                head = newNode;
            }
        }
        public void AddAtBeginning(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;
            Node temp = head;
            head = newNode;
            newNode.next = temp;
        }
        public void AddAfterElement(int value, int search)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;
            Node temp = head;
            while (temp != null && temp.data != search)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Element Not found");
            }
            else
            {
                Node temp2 = temp.next;
                temp.next = newNode;
                newNode.next = temp2;
            }
        }
        public void popFirstElement()
        {
            head = head.next;
        }
        public void popLast()
        {
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        public void display()
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }
    }
}
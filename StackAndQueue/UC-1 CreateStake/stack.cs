using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class stack
    {
        Node top = null;
        int sizeOfStack = 0;
        int MaxSize;
        public void StackUsingLinkedList(int size)
        {
            MaxSize = size;
        }
        public void push(int value)
        {
            if (sizeOfStack == MaxSize)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                Node newNode = new Node();
                newNode.data = value;
                newNode.next = top;
                top = newNode;
                sizeOfStack++;
            }
        }
        public void display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
                sizeOfStack--;
            }
        }
    }
}
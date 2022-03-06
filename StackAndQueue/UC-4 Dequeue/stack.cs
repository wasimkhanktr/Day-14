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
        public void peak()
        {
            Console.WriteLine(top.data);
        }
        public void pop()
        {
            if (sizeOfStack == 0)
                Console.WriteLine("Stack Underflow");
            else
            {
                top = top.next;
                sizeOfStack--;
            }
        }
    }
}
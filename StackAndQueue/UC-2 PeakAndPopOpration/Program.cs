using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stack stack1 = new stack();
            stack1.StackUsingLinkedList(3);
            stack1.push(30);
            stack1.push(70);
            stack1.push(56);
            stack1.peak();
            stack1.pop();
            stack1.peak();
            stack1.pop();
            stack1.peak();
            stack1.pop();
            stack1.pop();
        }
    }
}
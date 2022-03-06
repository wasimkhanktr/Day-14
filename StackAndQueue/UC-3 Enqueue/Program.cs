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
            Queue queue = new Queue();
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.display();
        }
    }
}
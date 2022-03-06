using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkListOperation list = new LinkListOperation();
            list.insert(56);
            list.insert(30);
            list.insert(70);
            list.display();
        }
    }
}
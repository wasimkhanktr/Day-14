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
            list.append(56);
            list.append(70);
            list.AddAfterElement(30, 56);
            list.display();
        }
    }
}
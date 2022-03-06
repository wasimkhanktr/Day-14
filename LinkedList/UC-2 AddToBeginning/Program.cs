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
            list.AddAtBeginning(70);
            list.AddAtBeginning(30);
            list.AddAtBeginning(56);
            list.display();
        }
    }
}
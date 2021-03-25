using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList LinkedList = new SingleLinkedList();

            LinkedList.Add(1);
            LinkedList.Add(10);
            LinkedList.Add(4);
            LinkedList.Add(22);

            LinkedList.Print();

            Console.ReadLine();
        }
    }
}

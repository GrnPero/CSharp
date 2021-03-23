using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStackDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> container = new Stack<int>();

            container.Push(1);
            container.Pop();
            container.Pop();

            Console.Write(container.Top());
            Console.ReadLine();
        }
    }
}

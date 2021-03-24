using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fib = new List<int>();
            int temp = 0, length = 10;

            fib.Add(0);
            fib.Add(1);

            for (int i = 0; i < length; i++)
            {
                temp = fib[i] + fib[i + 1];
                fib.Add(temp);
            }

            for (int i = 0; i < fib.Count; i++)
            {
                Console.WriteLine(fib[i]);
            }

            Console.ReadLine();
        }
    }
}

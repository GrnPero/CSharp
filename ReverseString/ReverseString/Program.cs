using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static string ReverseString(string input)
        {
            string result = "";

            for (int j = input.Length - 1; j >= 0; j--)
            {
                result += input[j];
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("We reverse ALL STRINGS\nEnter: ");
            string input = Console.ReadLine();

            Console.WriteLine("You Entered " + input + ".\n");
            
            Console.WriteLine(ReverseString(input));
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLetterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word and we will count it!\nEnter: ");
            string input = Console.ReadLine();
            int numWords = 0;

            char[] words = input.ToCharArray();

            foreach (char word in words)
            {
                if (word != ' ')
                    numWords++;
            }

            Console.WriteLine(numWords);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static bool IsLetter(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                return true;
            else
                return false;
        }

        static bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
                return true;

            char first = s[0];
            char last = s[s.Length - 1];

            first = Char.ToLower(first);
            last = Char.ToLower(last);

            if (!IsLetter(first))
            {
                return IsPalindrome(s.Substring(1));
            }
            else if (!IsLetter(last))
            {
                return IsPalindrome(s.Substring(0, s.Length - 1));
            }
            else if (first == last)
            {
                string shorter = s.Substring(1, s.Length - 2);
                return IsPalindrome(shorter);
            }
            else
                return false;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            if (!IsPalindrome(input)) 
            {
                Console.WriteLine("Not ");
            }

            Console.WriteLine("a palindrome.\n");

            string word = "Hello";

            int number = word.Length;
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}

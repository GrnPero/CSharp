using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            Console.WriteLine("Binary Time!");
            tree.insert(8);
            tree.insert(6);
            tree.insert(10);
            tree.insert(1);

            tree.inOrder();

            Console.ReadLine();
        }
    }
}

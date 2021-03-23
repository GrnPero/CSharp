using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStackDataStructure
{
    class Stack<T>
    {
        // The data structure that holds the template data
        private List<T> container = new List<T>();

        public Stack() { }

        public void Push(T x) { container.Add(x); }

        public void Pop()
        {
            if (container.Count != 0)
            {
                container.RemoveAt(container.Count - 1);
            }
            else
            {
                Console.WriteLine("\nEmpty Stack");
            }
        }

        public T Top()
        {
            T x = default(T);
            if (container.Count != 0)
            {
                return container[container.Count - 1];
            }
            else
            {
                Console.WriteLine("\nCan't perform the top() function!\n");
                return x;
            }
        }

        public bool Empty()
        {
            if (container.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

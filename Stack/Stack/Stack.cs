using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        // The data structure that holds the template data
        private List<T> container;

        public Stack() { }

        public void push(T x) { container.Add(x);  }
        
        public void pop()
        {
            if (container.Count != 0)
            {
                container.RemoveAt(container.Count - 1);
            } else
            {
                Console.WriteLine("\nEmpty Stack");
            }
        }

        public T top()
        {
            T x = default(T);
            if (container.Count != 0)
            {
                return container[container.Count - 1];
            } else
            {
                Console.WriteLine("\nCan't perform the top() function!\n");
                return x;
            }
        }

        public bool empty()
        {
            if (container.Count == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }



    }
}

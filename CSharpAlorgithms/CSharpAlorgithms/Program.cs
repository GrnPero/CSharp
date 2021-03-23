using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class Program
    {
        static void bubbleSort(List<int> l)
        {
            int i, j,
                n = l.Count;

            for (i = n - 1; i > 0; i--)
                for (j = 0; j < i; j++)
                    if (l[j] > l[j + 1]) {
                        int temp = l[j];
                        l[j] = l[j + 1];
                        l[j + 1] = temp;
                    }
        }

        static void insertionSort(List<int> l)
        {
            int i, j,
                elem, n = l.Count;

            for (i = 1; i < n; i++)
            {
                for (elem = l[i], j = i - 1; j >= 0 && elem < l[j]; j--)
                    l[j + 1] = l[j];
                l[j + 1] = elem;
            }
        }

        static void selectionSort(List<int> l)
        {
            int i, j,
                n = l.Count;

            for (i = 0; i < n-1; i++)
                for (j = i+1; j < n; j++)
                    if (l[i] > l[j])
                    {
                        int temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;          
                    }

        }

        static void print(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(5);
            list1.Add(2);
            list1.Add(3);
            list1.Add(1);
            list1.Add(3);

            print(list1);
            bubbleSort(list1);
            print(list1);

            List<int> list2 = new List<int>();
            list2.Add(5);
            list2.Add(2);
            list2.Add(3);
            list2.Add(1);
            list2.Add(3);

            print(list2);
            insertionSort(list2);
            print(list2);

            List<int> list3 = new List<int>();
            list3.Add(5);
            list3.Add(2);
            list3.Add(3);
            list3.Add(1);
            list3.Add(3);

            print(list3);
            selectionSort(list3);
            print(list3);

            Console.ReadLine();
        }
    }
}

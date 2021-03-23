using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LifeRay
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> transaction = new List<Product>();
            string[] exempt = { "book", "pills", "chocolate", "chocolates" };
            string fileContent;
            double totalTax = 0, subTotal = 0, total;

            Console.WriteLine("Enter File name: ");
            string fileName = Console.ReadLine();

            try
            {
                using (StreamReader file = new StreamReader(fileName))
                {
                    while ((fileContent = file.ReadLine()) != null)
                    {
                        int quantity;
                        bool isImport = false, isExempt = false;
                        double price;
                        string name;

                        string[] wordsContent = fileContent.Split(' ');

                        quantity = int.Parse(wordsContent[0]);
                        price = double.Parse(wordsContent[wordsContent.Length - 1]);

                        if (wordsContent[1] == "imported")
                        {
                            isImport = true;
                        }

                        // Converts string array to one string and checks for exempt products
                        StringBuilder builder = new StringBuilder();
                        for (int i = 1; i < wordsContent.Length - 2; i++)
                        {
                            builder.Append(wordsContent[i]);
                            if (i != (wordsContent.Length - 3))
                            {
                                builder.Append(" ");
                            }

                            for (int j = 0; j < exempt.Length; j++)
                            {
                                if (wordsContent[i] == exempt[j])
                                {
                                    isExempt = true;
                                }
                            }
                        }

                        // Converts the string[] to string
                        name = builder.ToString();

                        transaction.Add(new Product(quantity, name, price, isImport, isExempt));
                    }
                }

                for (int i = 0; i < transaction.Count; i++)
                {
                    totalTax += transaction[i].getTaxRate();
                    subTotal += transaction[i].getPrice() * transaction[i].getQuantity();
                    double list = transaction[i].getTaxRate() + transaction[i].getPrice();

                    Console.WriteLine(transaction[i].getQuantity() + " " + transaction[i].getName() + ": " + list);
                }

                total = totalTax + subTotal;

                Console.WriteLine("Sales Tax: " + totalTax);
                Console.WriteLine("Total: " + total);

                Console.ReadLine();
            } catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}

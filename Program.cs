using System;
using System.Collections.Generic;

namespace ProductManager
{
    class Program
    {
        static List<string> products = new List<string>();

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Product Manager ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. List Products");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        products.Add(name);
                        Console.WriteLine("Product added.");
                        break;
                    case 2:
                        Console.WriteLine("--- Product List ---");
                        if (products.Count == 0)
                            Console.WriteLine("No products found.");
                        else
                            products.ForEach(p => Console.WriteLine($"- {p}"));
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (choice != 3);
        }
    }
}

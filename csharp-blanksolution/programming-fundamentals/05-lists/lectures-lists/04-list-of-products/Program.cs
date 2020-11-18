using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_list_of_products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            List<string> products = new List<string>();

            while (counter <= n)
            {
                string product = Console.ReadLine();

                products.Add(product);

                counter++;
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }

            //алгоритмично знание -> можеш да сортираш по първа буква чрез намирането на най-малкото число -> char symbol 
            //по-важния извод -> не хаби време за нещо което вече е реализирано, ползвай го на готово и не хаби време, което прекрасно го разбираш :)
        }
    }
}

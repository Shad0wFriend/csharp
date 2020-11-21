using System;

namespace _02_syedinqvane_na_tekst_i_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-year old person from {3}.", firstName, lastName, age, town);
        }
    }
}

using System;

namespace _01_pozdrav_po_ime
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");//interpulaciq
            Console.WriteLine("Hello, " + name + "!");//konkatenaciq
            Console.WriteLine("Hello, {0}!", name);//placeholder
        }
    }
}

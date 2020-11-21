using System;

namespace _02_parola
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            while (true)
            {
                string temp = Console.ReadLine();

                if (temp == password)
                {
                    Console.WriteLine("Welcome " + name + "!");
                    break;
                }
            }
        }
    }
}

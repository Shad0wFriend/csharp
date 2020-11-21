using System;

namespace _01_starata_biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int counter = 1;

            while (true)
            {
                string book = Console.ReadLine();

                if (wantedBook == book && counter <= capacity)
                {
                    Console.WriteLine($"You checked {counter - 1} books and found it.");
                    break;
                }
                else if (counter >= capacity)
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }

                counter++;
            }
        }
    }
}

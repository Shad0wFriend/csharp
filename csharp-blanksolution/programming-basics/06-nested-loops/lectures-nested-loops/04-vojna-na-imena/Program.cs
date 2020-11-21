using System;

namespace _04_vojna_na_imena
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int biggest = int.MinValue;
            string winner = "";

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "STOP")
                {
                    Console.WriteLine($"Winner is {winner} - {biggest}!");
                    break;
                }

                foreach (char letter in name)
                {
                    points += letter;
                }

                if (biggest < points)
                {
                    biggest = points;

                    winner = name;
                }

                points = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _03_house_party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            List<string> guests = new List<string>();

            while (counter <= n)
            {
                string input = Console.ReadLine();

                string[] commands = input.Split(' ');

                string delimeter = commands[1] + " " + commands[2];

                if (delimeter == "is going!")
                {
                    if (guests.Contains(commands[0]))
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(commands[0]);
                    }
                }
                else if (delimeter == "is not")
                {
                    if (guests.Contains(commands[0]))
                    {
                        guests.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }

                counter++;
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}

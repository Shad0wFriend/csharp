using System;

namespace _03_pytuvane
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            double budget = 0;
            double money = 0;
            string destination = "";
            bool isNullified = false;

            while (true)
            {
                if (money >= budget && counter > 2)
                {
                    Console.WriteLine("Going to " + destination + "!");

                    money = 0;
                    counter = 1;

                    isNullified = true;
                }

                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (counter == 1)
                {
                    destination = input;
                }
                else if (counter == 2)
                {
                    budget = double.Parse(input);
                }

                if (counter > 2 && isNullified == false)
                {
                    money += double.Parse(input);
                }

                if (counter > 2 && isNullified == true)
                {
                    money += double.Parse(input);
                }

                counter++;
            }
        }
    }
}

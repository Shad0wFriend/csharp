using System;

namespace _05_login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            int counter = 1;

            while (true)
            {
                if (counter == 5)
                {
                    Console.WriteLine($"User {username} blocked!");

                    break;
                }

                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");

                    break;
                }
                else
                {
                    if (counter == 4)
                    {
                        counter++;

                        continue;
                    }

                    Console.WriteLine("Incorrect password. Try again.");

                    counter++;
                }
            }
        }
    }
}

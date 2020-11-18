using System;

namespace _04_password_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PasswordChecker(text);
        }

        public static void PasswordChecker(string text)
        {
            int length = text.Length;

            int validator = 0;

            if (!(length >= 6 && length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                validator += 2;
            }

            foreach (char symbol in text)
            {
                int value = symbol;

                if ((value >= 65 && value <= 90) || (value >= 97 && value <= 122) || (value >= 48 && value <= 57))
                {
                    continue;
                }

                Console.WriteLine("Password must consist only of letters and digits");

                validator--;

                break;
            }

            int counter = 0;

            foreach (char symbol in text)
            {
                int value = symbol;

                if (value >= 48 && value <= 57)
                {
                    counter++;
                }
            }

            if (counter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                validator++;
            }

            if (validator == 3)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

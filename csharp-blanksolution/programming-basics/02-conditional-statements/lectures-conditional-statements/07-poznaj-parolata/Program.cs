using System;

namespace _07_poznaj_parolata
{
    class Program
    {
        static void Main(string[] args)
        {
            string pwd = Console.ReadLine();

            if (pwd == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

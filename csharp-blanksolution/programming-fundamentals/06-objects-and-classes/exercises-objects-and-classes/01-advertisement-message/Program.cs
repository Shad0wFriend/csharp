using System;
using System.Collections.Generic;

namespace _01_advertisement_message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrase = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am verry satisfied.",
                "I feel great!"
            };

            List<string> authors = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            List<string> cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            string result = "";

            Random number = new Random();

            int index = number.Next(0, phrase.Count - 1);

            result += phrase[index] + " ";

            index = number.Next(0, events.Length - 1);

            result += events[index] + " ";

            index = number.Next(0, authors.Count - 1);

            result += authors[index] + " ";

            index = number.Next(0, cities.Count - 1);

            result += cities[index];

            Console.WriteLine(result);

            //Next() е различен всеки път :)
        }
    }
}

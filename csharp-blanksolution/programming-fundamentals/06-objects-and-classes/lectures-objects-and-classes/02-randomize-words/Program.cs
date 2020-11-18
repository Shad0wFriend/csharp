using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_randomize_words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();

            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int number = rnd.Next(0, words.Count - 1);

                string tmp = words[number];

                words[number] = words[i];

                words[i] = tmp;
            }

            foreach (string element in words)
            {
                Console.WriteLine(element);
            }
        }
    }
}

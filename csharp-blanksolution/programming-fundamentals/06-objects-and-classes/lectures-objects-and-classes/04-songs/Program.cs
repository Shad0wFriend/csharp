using System;
using System.Collections.Generic;

namespace _04_songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            List<object> objects = new List<object>();

            while (counter < n)
            {
                string input = Console.ReadLine();

                string[] data = input.Split('_');

                Song obj = new Song(data[0], data[1], data[2]);

                objects.Add(obj);

                counter++;
            }

            string delimeter = Console.ReadLine();

            foreach (Song song in objects)
            {
                if (delimeter == "all")
                {
                    Console.WriteLine(song.Name);

                    continue;
                }

                if (song.Playlist == delimeter)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}

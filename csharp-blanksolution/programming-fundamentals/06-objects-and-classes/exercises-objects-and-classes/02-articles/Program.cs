using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> data = input.Split(", ").ToList();

            int n = int.Parse(Console.ReadLine());

            Article article = new Article(data[0], data[1], data[2]);

            for (int i = 1; i <= n; i++)
            {
                input = Console.ReadLine();

                string[] commands = input.Split(": ");

                if (commands[0] == "Edit")
                {
                    article.Edit(commands[1]);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commands[1]);
                }
                else if (commands[0] == "Rename")
                {
                    article.Rename(commands[1]);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}

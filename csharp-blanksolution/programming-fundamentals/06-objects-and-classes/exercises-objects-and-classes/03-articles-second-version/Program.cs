using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_articles_second_version
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 1; i <= n; i++)
            {
                List<string> data = Console.ReadLine().Split(", ").ToList();

                Article article = new Article(data[0], data[1], data[2]);

                articles.Add(article);
            }

            string delimeter = Console.ReadLine();

            if (delimeter == "title")
            {
                foreach (Article art in articles.OrderBy(t => t.Title))
                {
                    Console.WriteLine(art.ToString());
                }
            }
            else if (delimeter == "content")
            {
                foreach (Article art in articles.OrderBy(c => c.Content))
                {
                    Console.WriteLine(art.ToString());
                }
            }
            else if (delimeter == "author")
            {
                foreach (Article art in articles.OrderBy(a => a.Author))
                {
                    Console.WriteLine(art.ToString());
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _03_articles_second_version
{
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string v1, string v2, string v3)
        {
            this.Title = v1;
            this.Content = v2;
            this.Author = v3;
        }

        public override string ToString()
        {
            return this.Title + " - " + this.Content + ": " + this.Author;
        }
    }
}

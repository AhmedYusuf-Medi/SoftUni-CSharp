using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Articles> articles = new List<Articles>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Articles article = new Articles(title, content, author);
                articles.Add(article);
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
                articles.Sort((x1, x2) => x1.Content.CompareTo(x2.Content));
            }
            else if (criteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
        class Articles
        {
            public Articles(string title, string content, string author)
            {
                Title = title;
                Author = author;
                Content = content;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}

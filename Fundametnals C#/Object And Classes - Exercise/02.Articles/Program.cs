using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comandInput = Console.ReadLine().Split(": ");
                string comand = comandInput[0];
                string change = comandInput[1];

                switch (comand)
                {
                    case "Edit":
                        article.Edit(change);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(change);
                        break;
                    case "Rename":
                        article.Rename(change);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
        class Article
        {
            public Article(string title,string content,string author)
            {
                Title = title;
                Author = author;
                Content = content;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Edit(string content)
            {
                Content = content;
            }
            public void ChangeAuthor (string author)
            {
                Author = author;
            }
            public void Rename (string title)
            {
                Title = title;
            }
            
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}

using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bans = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var ban in bans)
            {
                string replace = new string('*', ban.Length);

                text = text.Replace(ban, replace);
            }

            Console.WriteLine(text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> users = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var user in users)
            {
                bool isTrueChars = user.All(c => Char.IsLetterOrDigit(c) || c == '-' || c == '_');
                bool isTrueSize = user.Length > 3 && user.Length < 16;

                if (isTrueChars && isTrueSize)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}
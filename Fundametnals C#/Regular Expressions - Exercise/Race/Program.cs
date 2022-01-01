using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contestants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dic = new Dictionary<string, int>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = "[A-Za-z]";
                string digit = @"\d";

                var nameMatch = Regex.Matches(input, name);
                var kmMatch = Regex.Matches(input,digit);

                var currName = String.Concat(nameMatch);
                var sum = kmMatch.Select(x => int.Parse(x.Value)).Sum();

                if (contestants.Contains(currName))
                {
                    if (dic.ContainsKey(currName))
                    {
                        dic[currName] += sum;
                    }
                    else
                    {
                        dic.Add(currName, sum);
                    }
                }
            }
            var sorted = dic.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();


            Console.WriteLine("1st place: " +sorted[0]);
            Console.WriteLine("2nd place: " +sorted[1]);
            Console.WriteLine("3rd place: " +sorted[2]);

        }
    }
}
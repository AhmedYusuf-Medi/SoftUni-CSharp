using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vips = new HashSet<string>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "PARTY")
            {
                    bool isDigit = char.IsDigit(input[0]);
                    if (isDigit)
                    {
                        vips.Add(input);
                    }
                    else
                    {
                        guests.Add(input);
                    }
            }
            while ((input = Console.ReadLine()) != "END")
            {
                if (vips.Contains(input))
                {
                    vips.Remove(input);
                }
                else if (guests.Contains(input))
                {
                    guests.Remove(input);
                }
            }

            int count = guests.Count + vips.Count;
            Console.WriteLine(count);

            Console.WriteLine(string.Join(Environment.NewLine,vips));
            Console.WriteLine(string.Join(Environment.NewLine,guests));

        }
    }
}

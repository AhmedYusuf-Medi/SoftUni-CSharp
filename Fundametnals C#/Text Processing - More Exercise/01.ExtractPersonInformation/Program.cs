using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < loops; i++)
            {
                string input = Console.ReadLine();

                int startIndexOfName = input.IndexOf("@") + 1;
                int lengthOfName = input.IndexOf("|") - startIndexOfName;

                int startIndexOfAge = input.IndexOf("#") + 1;
                int lengthOfAge = input.IndexOf("*") - startIndexOfAge;

                string name = input.Substring(startIndexOfName, lengthOfName);
                int age = int.Parse(input.Substring(startIndexOfAge, lengthOfAge));
                output.AppendLine($"{name} is {age} years old.");
            }
            Console.WriteLine(output.ToString());
        }
    }
}

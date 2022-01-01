using System;
using System.Linq;

namespace _06.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = String.Empty;
            string a = Console.ReadLine();
            output += a + " ";
            string b = Console.ReadLine();
            output += b + " ";
            string c = Console.ReadLine();
            output += c;

            char[] charrArray = output.ToCharArray();
            Array.Reverse(charrArray);
            Console.WriteLine(charrArray);
        }
    }
}

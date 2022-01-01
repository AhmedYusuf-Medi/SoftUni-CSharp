using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(remove);

            while (index != -1)
            {
                text = text.Remove(index, remove.Length);

                index = text.IndexOf(remove);
            }

            Console.WriteLine(text);
        }
    }
}

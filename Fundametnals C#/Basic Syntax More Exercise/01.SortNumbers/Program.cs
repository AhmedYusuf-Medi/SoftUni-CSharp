using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());


            if (first > sec && first > third)
            {
                Console.WriteLine(first);
                if (sec > third)
                {
                    Console.WriteLine(sec);
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(third);
                    Console.WriteLine(sec);
                }
            }
            else if (sec > first && sec > third)
            {
                Console.WriteLine(sec);
                if (first > third)
                {
                    Console.WriteLine(first);
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(third);
                    Console.WriteLine(first);
                }
            }
            else if (third > first && third > sec)
            {
                Console.WriteLine(third);
                if (first > sec)
                {
                    Console.WriteLine(first);
                    Console.WriteLine(sec);
                }
                else
                {
                    Console.WriteLine(sec);
                    Console.WriteLine(first);
                }
            }

        }
    }
}

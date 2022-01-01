using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            while (people > 0)
            {
                people -= capacity;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

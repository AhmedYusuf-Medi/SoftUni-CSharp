using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDoubles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));

                boxes.Add(box);
            }

            double value = double.Parse(Console.ReadLine());

            int count = GetCountOfGreaterBox(boxes, value);

            Console.WriteLine(count);
        }

        private static int GetCountOfGreaterBox<T>(List<Box<T>> boxes, T value)
            where T: IComparable
        {
            int count = 0;
            foreach (var box in boxes)
            {
                if (box.Number.CompareTo(value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }

            string value = Console.ReadLine();

            int count = GetCountOfGreaterBox(boxes, value);

            Console.WriteLine(count);
        }

        private static int GetCountOfGreaterBox<T>(List<Box<T>> boxes, T value)
            where T: IComparable
        {
            int count = 0;
            foreach (var box in boxes)
            {
                if (box.Value.CompareTo(value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

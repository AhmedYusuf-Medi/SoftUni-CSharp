using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));

                boxes.Add(box);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SwapIndexes(boxes, indexes);

            Console.WriteLine(string.Join(Environment.NewLine, boxes));
        }

        public static void SwapIndexes<T>(List<Box<T>> boxes, int[] indexes)
        {
            int firstIndex = indexes[0];
            int secIndex = indexes[1];

            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secIndex];
            boxes[secIndex] = temp;      
        }
    }
}

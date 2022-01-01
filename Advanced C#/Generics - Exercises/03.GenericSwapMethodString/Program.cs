using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
      
            List<Box<string>> boxs = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            { 
                Box<string> currBox = new Box<string>(Console.ReadLine());
                boxs.Add(currBox);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SwapIndexes(boxs, indexes);

            foreach (Box<string> currBox in boxs)
            {
                Console.WriteLine(currBox);
            }

        }

        public static void SwapIndexes<T>(List<Box<T>> boxes, int[] indexes)
        {
            int firstIndex = indexes[0];
            int secIndex = indexes[1];
            Box<T> tmp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secIndex];
            boxes[secIndex] = tmp;
        }
    }

   
}
